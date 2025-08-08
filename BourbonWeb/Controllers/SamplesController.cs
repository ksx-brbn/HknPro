using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BourbonWeb.Data;
using BourbonWeb.Models;

namespace BourbonWeb.Controllers
{
    public class SamplesController : Controller
    {
        private readonly AppDbContext _context;

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

        private bool SampleExists(int id)
        {
            return _context.Sample.Any(e => e.Id == id);
        }
        #endregion

        #region 販促費申請情報(T_HANSOKU_SINSEI)
        public async Task<IActionResult> HansokuSinsei()
        {
            var sql = @"
SELECT TOP 10
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

            var list = await _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking()
                .ToListAsync();
            return View(list);
        }

        public async Task<IActionResult> Home(int? mainPageNumber, int? queryPageNumber)
        {
            var sql = @"
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

            var baseQuery = _context.HansokuSinsei
                .AsNoTracking();
            var queryResult = _context.HansokuSinsei
                .FromSqlRaw(sql)
                .AsNoTracking();
            int pageSize = 5;

            var viewModel = new HomeViewModel
            {
                MainList = await PaginatedList<HansokuSinsei>.CreateAsync(baseQuery, mainPageNumber ?? 1, pageSize),
                QueryList = await PaginatedList<HansokuSinsei>.CreateAsync(queryResult, queryPageNumber ?? 1, pageSize)
            };
            return View(viewModel);
        }
        #endregion
    }
}
