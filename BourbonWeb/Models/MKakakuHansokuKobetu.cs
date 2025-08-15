using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "価格販促個別マスタ")]
    public class MKakakuHansokuKobetu
    {
        [Column("TAISHO_YM")]
        [Display(Name = "対象年月")]
        public string? TaishoYm { get; set; }

        [Column("KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KaisiYmd { get; set; }

        [Column("SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? ShuryoYmd { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "伝票区分")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "販促区分")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "販促区分詳細")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "販促区分個別")]
        public string? HansokKbnKobetu { get; set; }

        [Column("SHO_CD")]
        [Display(Name = "所CD")]
        public string? ShoCd { get; set; }

        [Column("TOKUI_CD")]
        [Display(Name = "得意先CD")]
        public string? TokuiCd { get; set; }

        [Column("KOBETU_CD")]
        [Display(Name = "個別CD")]
        public string? KobetuCd { get; set; }

        [Column("KOBETU_NM")]
        [Display(Name = "個別名")]
        public string? KobetuNm { get; set; }

        [Column("MISE_JOKEN")]
        [Display(Name = "店条件")]
        public string? MiseJoken { get; set; }

        [Column("JOKEN_KBN")]
        [Display(Name = "条件区分")]
        public string? JokenKbn { get; set; }

        [Column("JOKEN")]
        [Display(Name = "条件")]
        public decimal? Joken { get; set; }

        [Column("URIAGE_SHOMEI")]
        [Display(Name = "売上証明")]
        public string? UriageShomei { get; set; }

        [Column("BIKO")]
        [Display(Name = "備考")]
        public string? Biko { get; set; }

        [Column("KOKAI_YMD")]
        [Display(Name = "公開年月日")]
        public string? KokaiYmd { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "登録年月日")]
        public string? TorokuYmd { get; set; }

        [Column("KOSIN_YMD")]
        [Display(Name = "更新年月日")]
        public string? KosinYmd { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "削除フラグ")]
        public string? DeleteFlg { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "売上控除判定")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "税率区分")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "一帯資産区分")]
        public string? IttaiSisanKbn { get; set; }

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "販促費目CD")]
        public string? HansokHimokuCd { get; set; }

    }
}