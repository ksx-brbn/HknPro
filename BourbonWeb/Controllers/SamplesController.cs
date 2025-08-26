using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using BourbonWeb.Data;
using BourbonWeb.Models;

namespace BourbonWeb.Controllers
{
    public class SamplesController : Controller
    {
        private readonly AppDbContext _context;
        private const string sql = @"
SELECT
    KAISHA_CD
    , URIKAKE_BUNRUI
    , CASE URIKAKE_BUNRUI
        WHEN '1' THEN '特約店'
        WHEN '4' THEN '登録店'
        ELSE ''
        END AS URIKAKE_BUNRUI_NM
    , SEIKYU_KBN
    , SINSEI_NO
    , SINSEI_SHURUI
    , SHUSEI_SINSEI_NO
    , SINSEI_TAISHO_YM
    , SINSEI_KEIJO_YM
    , KAIKEI_KEIJO_YM
    , SINSEI_KAGAMI_NO
    , SINSEI_KAGAMI_DAIHYO_NO
    , SINSEI_KAGAMI_DAIHYO_CD
    , SINSEI_SIHARAI_GROUP_CD
    , SINSEI_SEIKYU_CD
    , SINSEI_SEIKYU_NM
    , SINSEI_SEIKYU_BUNRUI_CD
    , SINSEI_CHOAI_CD
    , SINSEI_CHOAI_NM
    , SINSEI_CHOAI_BUNRUI_CD
    , SINSEI_SEIKYU_HONTEN_CD
    , SINSEI_SEIKYU_HONTEN_NM
    , SINSEI_SEIKYU_SIMEBI
    , SINSEI_SEIKYU_SHUKIN_BI
    , SINSEI_SEIKYU_KAISHU_SITE
    , SINSEI_SEIKYU_LAST_SIMEBI
    , KIKAKU_BUNRUI_NO
    , TORIHIKI_CD_A
    , TORIHIKI_NM_A
    , TORIHIKI_KANA_A
    , TORIHIKI_BUNRUI_CD
    , TORIHIKI_GYOTAI_KBN
    , TORIHIKI_CD_KBN
    , TORIHIKI_CD_B
    , TORIHIKI_KANJI_KBN
    , TORIHIKI_NM_B
    , TORIHIKI_AREA_CD
    , TORIHIKI_BUSHO_CD
    , TORIHIKI_EIGYO_CD
    , TORIHIKI_CENTER_CD
    , TORIHIKI_KEIYAKU_NO
    , TORIHIKI_KEIYAKU_HOZON
    , TORIHIKI_MITUMORI_NO
    , TORIHIKI_MITUMORI_HOZON
    , TORIHIKI_MISHU_SEIKYU_NO
    , TORIHIKI_MISHU_SEIKYU_HOZON
    , TORIHIKI_MISHU_NO
    , TORIHIKI_SEIKYU_SIME
    , SIHARAI_KEITAI
    , SIHARAI_SHUBETU
    , CASE SUBSTRING(SIHARAI_KEITAI, 1, 1)
        WHEN '1' THEN '請求書控除'
        WHEN '2' THEN '売掛金相殺'
        WHEN '3' THEN CASE SIHARAI_SHUBETU
            WHEN '1' THEN '振込（請求・帳合）'
            WHEN '2' THEN '振込（得意先）'
            ELSE ''
            END
        ELSE ''
        END AS SHORI_HOHO
    , SIHARAI_YOTEI_YMD
    , SIHARAI_KAKUTEI_YMD
    , SIHARAI_TETUZUKI_SHO_CD
    , SIHARAI_TETUZUKI_SHA_CD
    , SIHARAI_TETUZUKI_YMD
    , SIHARAI_TETUZUKI_TIME
    , MIBARAI_KANRI_KBN
    , MIBARAI_KANRI_SIME
    , MIBARAI_KANRI_SHORI_SIME_KBN
    , SIWAKE_KIDEN_YMD
    , SINSEI_COMMENT
    , KYOSAN_COMMENT_HYOSI_FLG
    , JOTAI_KBN
    , CASE JOTAI_KBN
        WHEN '0' THEN '申請登録'
        WHEN '1' THEN '鑑作成済'
        WHEN '2' THEN '印刷済'
        WHEN '3' THEN '承認済'
        WHEN '4' THEN '費用計上確定'
        WHEN '5' THEN '支払完了'
        ELSE ''
        END AS JOTAI_KBN_NM
    , '0' AS HONSHA_SHONIN_JOTAI_KBN
    , KEIHISHO_CD
    , KEIHISHO_NM
    , KEIHISHA_CD
    , KEIHISHA_NM
    , SINSEI_SHO_CD
    , IIF(SINSEI_SHO_NM = KEIHISHO_NM, '', SINSEI_SHO_NM) AS SINSEI_SHO_NM
    , SINSEI_SHA_CD
    , IIF(SINSEI_SHA_NM = KEIHISHA_NM, '', SINSEI_SHA_NM) AS SINSEI_SHA_NM
    , SINSEI_KAGAMI_SHO_CD
    , SINSEI_KAGAMI_SHO_NM
    , SINSEI_KAGAMI_SHA_CD
    , SINSEI_KAGAMI_SHA_NM
    , SINSEI_TOROKU_YMD
    , SINSEI_TOROKU_TIME
    , SINSEI_SHO_SAKUSEI_YMD
    , SINSEI_SHO_SAKUSEI_TIME
    , SINSEI_SHO_SAKUSEI_YMD_ZENKAI
    , SINSEI_SHO_SAKUSEI_TIME_ZENKAI
    , SINSEI_SHO_INSATU_YMD
    , SINSEI_SHO_INSATU_TIME
    , SINSEI_SHO_INSATU_CNT
    , SURYO_TANI_KBN
    , KYOSAN_JOKEN_TANI_KBN
    , KYOSAN_GAKU
    , KYOSAN_GAKU_ZEI_KBN
    , KYOSAN_GAKU_ZEI_GAKU
    , KYOSAN_GAKU_ZEI_NUKI
    , ZEI_HASU_SHORI_KBN
    , SINSEI_YMD
    , TAISHO_KAISI_YMD
    , TAISHO_SHURYO_YMD
    , MISE_BUNRUI
    , HACCHUSAKI_CD
    , HACCHUSAKI_NM
    , SHUSEI_KBN
    , SINSEI_ASSOCIATION_CD
    , TEISEI_SINSEI_NO
    , TEISEI_MOTO_SINSEI_NO
    , CHOFUKU_JOGAI
    , SHUSEI_KAGAMI_NO
    , MITUMORI_TEKIYO
    , KAKAKU_HANSOKU_KBN
    , REMARKS
    , CREATED_ID
    , CREATED_AT
    , UPDATED_ID
    , UPDATED_AT
    , DELETED_FLG
    , LOCK_VERSION
    , NEBIKI_SYUBETU
FROM
    T_HANSOKU_SINSEI 
";

        #region Sample CRUD Operations
        public SamplesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Samples
        public async Task<IActionResult> Index(string? searchString, int? pageNumber, int? pageSize)
        {
            var query = _context.Sample
                .AsNoTracking();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.Name.Contains(searchString));
            }

            query = query.OrderBy(s => s.Id);
            int currentPageSize = pageSize ?? 10;
            query = query.OrderBy(s => s.Id);
            ViewData["CurrentFilter"] = searchString;
            return View(await PaginatedList<Sample>.CreateAsync(query, pageNumber ?? 1, currentPageSize));
        }

        public async Task<IActionResult> ExportCsv(string? searchString)
        {
            var query = _context.Sample
                .AsNoTracking();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.Name.Contains(searchString));
            }

            var list = await query
                .OrderBy(s => s.Id)
                .ToListAsync();

            var sb = new StringBuilder();
            sb.AppendLine("名称,価格,説明,数量,重量,対象年月,支払日,更新日時,状態,文字1,文字2,文字3,文字4,文字5");

            foreach (var s in list)
            {
                sb.AppendLine(string.Join(",",
                    EscapeCsv(s.Name),
                    s.Price.ToString(),
                    EscapeCsv(s.Description),
                    s.Quantity?.ToString(),
                    s.Weight?.ToString(),
                    s.TargetYM?.ToString("yyyyMM"),
                    s.PaymentDate?.ToString("yyyyMMdd"),
                    s.UpdatedAt?.ToString("yyyy-MM-dd HH:mm:ss"),
                    EscapeCsv(s.IsActiveDisplay),
                    EscapeCsv(s.Text1),
                    EscapeCsv(s.Text2),
                    EscapeCsv(s.Text3),
                    EscapeCsv(s.Text4),
                    EscapeCsv(s.Text5)
                ));
            }

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "Sample.csv");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImportCsv(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["Error"] = "CSVファイルが選択されていません。";
                return RedirectToAction(nameof(Index));
            }

            using var reader = new StreamReader(file.OpenReadStream(), Encoding.UTF8);
            string? line;
            bool isFirst = true;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (isFirst)
                {
                    isFirst = false;
                    if (line.StartsWith("Id", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                }

                var fields = line.Split(',');
                if (fields.Length < 15)
                {
                    continue;
                }

                if (int.TryParse(fields[0], out var id))
                {
                    var existing = await _context.Sample.FindAsync(id);
                    if (existing != null)
                    {
                        SetSampleProperties(existing, fields);
                        continue;
                    }
                }

                var sample = new Sample();
                SetSampleProperties(sample, fields);
                _context.Sample.Add(sample);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Samples
        public async Task<IActionResult> Index2(string? searchString, int? pageNumber)
        {
            var query = _context.Sample
                .AsNoTracking();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.Name.Contains(searchString));
            }

            query = query.OrderBy(s => s.Id);
            int pageSize = 10;
            return View(await PaginatedList<Sample>.CreateAsync(query, pageNumber ?? 1, pageSize));
        }

        // GET: Samples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // GET: Samples/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Samples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Description,Quantity,Weight,TargetYM,PaymentDate,UpdatedAt,IsActive,Text1,Text2,Text3,Text4,Text5")] Sample sample)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sample);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sample);
        }

        // GET: Samples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample.FindAsync(id);
            if (sample == null)
            {
                return NotFound();
            }
            return View(sample);
        }

        // POST: Samples/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Description,Quantity,Weight,TargetYM,PaymentDate,UpdatedAt,IsActive,Text1,Text2,Text3,Text4,Text5")] Sample sample)
        {
            if (id != sample.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sample);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SampleExists(sample.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sample);
        }

        // GET: Samples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await _context.Sample
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // POST: Samples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sample = await _context.Sample.FindAsync(id);
            if (sample != null)
            {
                _context.Sample.Remove(sample);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private static string EscapeCsv(string? field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return string.Empty;
            }

            if (field.Contains('"') || field.Contains(',') || field.Contains('\n') || field.Contains('\r'))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }

            return field;
        }

        private static void SetSampleProperties(Sample sample, string[] fields)
        {
            sample.Name = fields[1];
            sample.Price = decimal.TryParse(fields[2], out var price) ? price : 0m;
            sample.Description = string.IsNullOrWhiteSpace(fields[3]) ? null : fields[3];
            sample.Quantity = int.TryParse(fields[4], out var quantity) ? quantity : null;
            sample.Weight = double.TryParse(fields[5], out var weight) ? weight : null;
            sample.TargetYM = DateOnly.TryParseExact(fields[6], "yyyyMM", CultureInfo.InvariantCulture, DateTimeStyles.None, out var ym) ? ym : null;
            sample.PaymentDate = DateOnly.TryParseExact(fields[7], "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var pd) ? pd : null;
            sample.UpdatedAt = DateTime.TryParse(fields[8], out var updatedAt) ? updatedAt : null;
            sample.IsActive = fields[9] switch
            {
                "有効" => true,
                "無効" => false,
                _ when bool.TryParse(fields[9], out var b) => b,
                _ => null
            };
            sample.Text1 = string.IsNullOrWhiteSpace(fields[10]) ? null : fields[10];
            sample.Text2 = string.IsNullOrWhiteSpace(fields[11]) ? null : fields[11];
            sample.Text3 = string.IsNullOrWhiteSpace(fields[12]) ? null : fields[12];
            sample.Text4 = string.IsNullOrWhiteSpace(fields[13]) ? null : fields[13];
            sample.Text5 = string.IsNullOrWhiteSpace(fields[14]) ? null : fields[14];
        }

        private bool SampleExists(int id)
        {
            return _context.Sample.Any(e => e.Id == id);
        }
        #endregion

        #region 販促費申請情報(T_HANSOKU_SINSEI)
        public async Task<IActionResult> HansokuSinsei()
        {
            var list = await _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking()
                .Take(10)
                .ToListAsync();
            return View(list);
        }

        public async Task<IActionResult> Home(int? mainPageNumber, int? queryPageNumber, int? mainPageSize, int? queryPageSize)
        {
            var baseQuery = _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking();

            baseQuery = baseQuery
                .OrderByDescending(s => s.SinseiNo);

            var queryResult = _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking();

            queryResult = queryResult
                .OrderByDescending(s => s.ShuseiKagamiNo)
                .ThenByDescending(s => s.SinseiNo);

            int mainSize = mainPageSize ?? 5;
            int querySize = queryPageSize ?? 5;
            var viewModel = new HomeViewModel
            {
                MainList = await PaginatedList<HansokuSinsei>.CreateAsync(baseQuery, mainPageNumber ?? 1, mainSize),
                QueryList = await PaginatedList<HansokuSinsei>.CreateAsync(queryResult, queryPageNumber ?? 1, querySize)
            };
            return View(viewModel);
        }

        public async Task<IActionResult> InputConditions(HansokuSinseiSearchCondition condition, int? pageNumber, int? pageSize)
        {
            if (string.IsNullOrEmpty(condition.SinseiTaishoYm))
            {
                condition.SinseiTaishoYm = "2024-08";
            }

            if (string.IsNullOrEmpty(condition.SiharaiYoteiYmd))
            {
                condition.SiharaiYoteiYmd = "2024-09-30";
            }

            if (string.IsNullOrEmpty(condition.KeihishoCd))
            {
                condition.KeihishoCd = "210300";
            }

            if (string.IsNullOrEmpty(condition.KeihishaCd))
            {
                condition.KeihishaCd = "063441";
            }

            if (string.IsNullOrEmpty(condition.SinseiChoaiCd))
            {
                condition.SinseiChoaiCd = "201632";
            }

            if (string.IsNullOrEmpty(condition.SeikyuKbn))
            {
                condition.SeikyuKbn = "0";
            }

            if (string.IsNullOrEmpty(condition.TorihikiCdA))
            {
                condition.TorihikiCdA = "XA0734";
            }

            if (string.IsNullOrEmpty(condition.ShoriHoho))
            {
                condition.ShoriHoho = "20;";
            }

            if (string.IsNullOrEmpty(condition.KyosanJokenTaniKbn))
            {
                condition.KyosanJokenTaniKbn = "0";
            }

            if (string.IsNullOrEmpty(condition.KakakuHansokuKbn))
            {
                condition.KakakuHansokuKbn = "1";
            }

            if (string.IsNullOrEmpty(condition.CreateKeihiRitu))
            {
                condition.CreateKeihiRitu = "0";
            }

            var baseQuery = _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking();

            if (!string.IsNullOrEmpty(condition.SinseiTaishoYm))
            {
                var ym = condition.SinseiTaishoYm.Replace("-", "").Replace("年", "").Replace("月", "");
                baseQuery = baseQuery.Where(s => s.SinseiTaishoYm == ym);
            }

            if (!string.IsNullOrEmpty(condition.KeihishoCd))
            {
                baseQuery = baseQuery.Where(s => s.KeihishoCd == condition.KeihishoCd);
            }

            if (!string.IsNullOrEmpty(condition.SinseiChoaiCd))
            {
                baseQuery = baseQuery.Where(s => s.SinseiChoaiCd == condition.SinseiChoaiCd);
            }

            if (!string.IsNullOrEmpty(condition.SeikyuKbn))
            {
                baseQuery = baseQuery.Where(s => s.SeikyuKbn == condition.SeikyuKbn);
            }

            baseQuery = baseQuery
                .OrderByDescending(s => s.SinseiNo);

            int currentPageSize = pageSize ?? 5;
            ViewData["CurrentSinseiTaishoYm"] = condition.SinseiTaishoYm;
            ViewData["CurrentSiharaiYoteiYmd"] = condition.SiharaiYoteiYmd;
            ViewData["CurrentSinseiShoCd"] = condition.SinseiShoCd;
            ViewData["CurrentSinseiShaCd"] = condition.SinseiShaCd;
            ViewData["CurrentSinseiSeikyuCd"] = condition.SinseiSeikyuCd;
            ViewData["CurrentSeikyuKbn"] = condition.SeikyuKbn;
            ViewData["CurrentTorihikiCdA"] = condition.TorihikiCdA;
            ViewData["CurrentKeihishoCd"] = condition.KeihishoCd;
            ViewData["CurrentKeihishaCd"] = condition.KeihishaCd;
            ViewData["CurrentSinseiChoaiCd"] = condition.SinseiChoaiCd;
            ViewData["CurrentShoriHoho"] = condition.ShoriHoho;
            ViewData["CurrentKyosanJokenTaniKbn"] = condition.KyosanJokenTaniKbn;
            ViewData["CurrentKakakuHansokuKbn"] = condition.KakakuHansokuKbn;
            ViewData["CurrentCreateKeihiRitu"] = condition.CreateKeihiRitu;
            var list = await PaginatedList<HansokuSinsei>.CreateAsync(baseQuery, pageNumber ?? 1, currentPageSize);
            return View(list);
        }

        public IActionResult CRV0020Sample()
        {
            return View();
        }

        public IActionResult CRV0021Sample()
        {
            return View();
        }

        public IActionResult CRV0022Sample()
        {
            return View();
        }

        public IActionResult CRV0023Sample()
        {
            return View();
        }

        public IActionResult CRV0024Sample()
        {
            return View();
        }

        public IActionResult CRV0025Sample()
        {
            return View();
        }

        public IActionResult CRV0026Sample()
        {
            return View();
        }

        public IActionResult CRV0030Sample()
        {
            return View();
        }

        public IActionResult CRE0010Sample()
        {
            return View();
        }

        public IActionResult CRR0010Sample()
        {
            return View();
        }

        public IActionResult CRR0020Sample()
        {
            return View();
        }

        public IActionResult PRV0010Sample()
        {
            return View();
        }

        public IActionResult PRV0020Sample()
        {
            return View();
        }

        public IActionResult PRV0021Sample()
        {
            return View();
        }

        public IActionResult PRV0022Sample()
        {
            return View();
        }


        public IActionResult PGV0010Sample()
        {
            return View();
        }

        public IActionResult PGV0011Sample()
        {
            return View();
        }

        public IActionResult PGV0012Sample()
        {
            return View();
        }

        public IActionResult PGV0013Sample()
        {
            return View();
        }

        public IActionResult PGB0010Sample()
        {
            return View();
        }

        public IActionResult CPV0010Sample()
        {
            return View();
        }

        public IActionResult CPB0010Sample()
        {
            return View();
        }

        public IActionResult CPB0020Sample()
        {
            return View();
        }

        public IActionResult CPB0030Sample()
        {
            return View();
        }

        public IActionResult CPB0040Sample()
        {
            return View();
        }

        public IActionResult CPB0050Sample()
        {
            return View();
        }

        public IActionResult CPB0060Sample()
        {
            return View();
        }

        public IActionResult PPV0010Sample()
        {
            return View();
        }

        public IActionResult PPV0011Sample()
        {
            return View();
        }

        public IActionResult PPV0012Sample()
        {
            return View();
        }

        public IActionResult PPV0013Sample()
        {
            return View();
        }

        public IActionResult PPV0020Sample()
        {
            return View();
        }

        public IActionResult PPV0030Sample()
        {
            return View();
        }

        public IActionResult PPV0031Sample()
        {
            return View();
        }

        public IActionResult PPR0010Sample()
        {
            return View();
        }

        public IActionResult RAV0010Sample()
        {
            return View();
        }

        public IActionResult RAV0020Sample()
        {
            return View();
        }

        public IActionResult RAV0030Sample()
        {
            return View();
        }

        public IActionResult RAV0031Sample()
        {
            return View();
        }

        public IActionResult RAV0040Sample()
        {
            return View();
        }

        public IActionResult RAR0010Sample()
        {
            return View();
        }

        public IActionResult RAR0020Sample()
        {
            return View();
        }

        public IActionResult RAR0030Sample()
        {
            return View();
        }

        public IActionResult RAR0040Sample()
        {
            return View();
        }

        public IActionResult RAR0050Sample()
        {
            return View();
        }

        public IActionResult RAR0060Sample()
        {
            return View();
        }

        public IActionResult RAR0070Sample()
        {
            return View();
        }

        public IActionResult RAR0080Sample()
        {
            return View();
        }

        public IActionResult RAR0090Sample()
        {
            return View();
        }

        public IActionResult RAV0050Sample()
        {
            return View();
        }

        public IActionResult CMV0010Sample()
        {
            return View();
        }

        public IActionResult CMV0030Sample()
        {
            return View();
        }

        public IActionResult CMV0040Sample()
        {
            return View();
        }

        public IActionResult CMV0050Sample()
        {
            return View();
        }

        public IActionResult CMV0060Sample()
        {
            return View();
        }

        public IActionResult CMV0070Sample()
        {
            return View();
        }

        public IActionResult CMV0080Sample()
        {
            return View();
        }

        public IActionResult CMV9010Sample()
        {
            return View();
        }

        public IActionResult CMB0010Sample()
        {
            return View();
        }

        public IActionResult CMB0020Sample()
        {
            return View();
        }

        public IActionResult CMB0030Sample()
        {
            return View();
        }

        public IActionResult CMB0040Sample()
        {
            return View();
        }

        public IActionResult CMB0050Sample()
        {
            return View();
        }
        #endregion
    }
}
