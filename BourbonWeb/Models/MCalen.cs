using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "カレンダーマスタ")]
    public class MCalen
    {
        [Column("KY_KADO_YMD")]
        [Display(Name = "稼働年月日")]
        public string? KyKadoYmd { get; set; }

        [Column("KY_KADO_KBN")]
        [Display(Name = "稼働区分")]
        public string? KyKadoKbn { get; set; }

        [Column("KY_KADOBASHO_CD")]
        [Display(Name = "稼働場所CD")]
        public string? KyKadobashoCd { get; set; }

        [Column("KKADO_KEITAI")]
        [Display(Name = "稼働形態")]
        public string? KkadoKeitai { get; set; }

        [Column("KYUJITU_KEITAI")]
        [Display(Name = "休日形態")]
        public string? KyujituKeitai { get; set; }

        [Column("NICHISAIJITU")]
        [Display(Name = "日祭日")]
        public string? Nichisaijitu { get; set; }

        [Column("YOBI")]
        [Display(Name = "曜日")]
        public string? Yobi { get; set; }

        [Column("RUIKEI_KADO_NISU")]
        [Display(Name = "累計稼働日数")]
        public decimal? RuikeiKadoNisu { get; set; }

        [Column("GEKAN_KADO_NISU")]
        [Display(Name = "月間稼働日数")]
        public decimal? GekanKadoNisu { get; set; }

        [Column("RUIKEI_KYUJITU_NISU")]
        [Display(Name = "累計休日日数")]
        public decimal? RuikeiKyujituNisu { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "登録年月日")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "登録時分")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "削除フラグ")]
        public string? DeleteFlg { get; set; }

        [Column("HAISIN_FLG")]
        [Display(Name = "配信フラグ")]
        public string? HaisinFlg { get; set; }

        [Column("HAISIN_YMD")]
        [Display(Name = "配信年月日")]
        public string? HaisinYmd { get; set; }

    }
}
