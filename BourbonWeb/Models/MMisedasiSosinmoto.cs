using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "店出送信元マスタ")]
    public class MMisedasiSosinmoto
    {
        [Column("TORIHIKI_KEIRO")]
        [Display(Name = "取引先経路")]
        public string? TorihikiKeiro { get; set; }

        [Column("SOSIN_MOTO_CD")]
        [Display(Name = "送信元コード")]
        public string? SosinMotoCd { get; set; }

        [Column("BUNRUI_CD")]
        [Display(Name = "分類コード")]
        public string? BunruiCd { get; set; }

        [Column("SOSIN_MOTO_NM")]
        [Display(Name = "送信元名称")]
        public string? SosinMotoNm { get; set; }

        [Column("BOURBON_SOSIN_MOTO_NM")]
        [Display(Name = "ブルボン表示用送信元名称")]
        public string? BourbonSosinMotoNm { get; set; }

        [Column("BOURBON_HONTEN_CD")]
        [Display(Name = "ブルボン本店コード")]
        public string? BourbonHontenCd { get; set; }

        [Column("BOURBON_TOKUI_CD")]
        [Display(Name = "ブルボン得意先コード")]
        public string? BourbonTokuiCd { get; set; }

        [Column("BOURBON_TANTO_SHO_CD")]
        [Display(Name = "ブルボン担当所コード")]
        public string? BourbonTantoShoCd { get; set; }

        [Column("JUSIN_CYCLE")]
        [Display(Name = "受信サイクル")]
        public string? JusinCycle { get; set; }

        [Column("SAISIN_JUSINBI")]
        [Display(Name = "最新受信日")]
        public string? SaisinJusinbi { get; set; }

        [Column("BIKO")]
        [Display(Name = "備考")]
        public string? Biko { get; set; }

        [Column("TOROKUBI")]
        [Display(Name = "登録日")]
        public string? Torokubi { get; set; }

        [Column("SORTKEY")]
        [Display(Name = "ソート区分")]
        public string? Sortkey { get; set; }

        [Column("HYOJI_KBN")]
        [Display(Name = "表示区分")]
        public string? HyojiKbn { get; set; }

    }
}