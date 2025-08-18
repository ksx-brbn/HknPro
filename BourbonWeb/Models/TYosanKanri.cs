using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "—\ZŠÇ—")]
    public class TYosanKanri
    {
        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "”„Š|•ª—Ş")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "¿‹‹æ•ª")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "¿‹æCD")]
        public string? SeikyuCd { get; set; }

        [Column("SEIKYU_NM")]
        [Display(Name = "¿‹æ–¼")]
        public string? SeikyuNm { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "“`•[‹æ•ª")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "”Ì‘£‹æ•ª")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "”Ì‘£‹æ•ªÚ×")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "”Ì‘£‹æ•ªŒÂ•Ê")]
        public string? HansokKbnKobetu { get; set; }

        [Column("HANSOK_HIMOKU_NM")]
        [Display(Name = "”Ì‘£”ï–Ú–¼")]
        public string? HansokHimokuNm { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "‘ÎÛ”NŒ")]
        public string? TaishoYm { get; set; }

        [Column("YOSAN_GAKU_TOGETU")]
        [Display(Name = "“–Œ—\Z")]
        public decimal? YosanGakuTogetu { get; set; }

        [Column("YOSAN_GAKU_ZENGETU")]
        [Display(Name = "‘OŒ—\Z")]
        public decimal? YosanGakuZengetu { get; set; }

        [Column("YOSAN_GAKU_ZEN2GETU")]
        [Display(Name = "‘OXŒ—\Z")]
        public decimal? YosanGakuZen2getu { get; set; }

        [Column("YOSAN_GAKU_KURIKOSI")]
        [Display(Name = "ŒJ‰z•ª—\Z")]
        public decimal? YosanGakuKurikosi { get; set; }

        [Column("KYOSAN_GAKU_TOGETU")]
        [Display(Name = "“–ŒÀÑ‹¦^Šz")]
        public decimal? KyosanGakuTogetu { get; set; }

        [Column("KYOSAN_GAKU_ZENGETU")]
        [Display(Name = "‘OŒÀÑ‹¦^Šz")]
        public decimal? KyosanGakuZengetu { get; set; }

        [Column("KYOSAN_GAKU_ZEN2GETU")]
        [Display(Name = "‘OXŒÀÑ‹¦^Šz")]
        public decimal? KyosanGakuZen2getu { get; set; }

        [Column("ZEN2GETU_FUSOKU_GAKU")]
        [Display(Name = "‘OXŒ—\Z’´‰ßŠz")]
        public decimal? Zen2getuFusokuGaku { get; set; }

        [Column("JIGETU_KURIKOSI_GAKU")]
        [Display(Name = "ŸŒŒJ‰zŠz")]
        public decimal? JigetuKurikosiGaku { get; set; }

        [Column("REMARKS")]
        [Display(Name = "”õl")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "“o˜^Ò")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "“o˜^“ú")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "XVÒ")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "XV“ú")]
        public DateTime? UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "íœƒtƒ‰ƒO")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ƒƒbƒNƒo[ƒWƒ‡ƒ“")]
        public int? LockVersion { get; set; }
    }
}