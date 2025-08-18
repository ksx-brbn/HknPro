using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "店出連携情報")]
    public class TMisedasiRenkei
    {
        [Column("TAISHO_YM")]
        [Display(Name = "対象年月")]
        public string? TaishoYm { get; set; }

        [Column("SOSIN_MOTO_CD")]
        [Display(Name = "送信元コード")]
        public string? SosinMotoCd { get; set; }

        [Column("SOSIN_MOTO_NM")]
        [Display(Name = "送信元企業名")]
        public string? SosinMotoNm { get; set; }

        [Column("ICHIJITEN_CD")]
        [Display(Name = "一次店コード")]
        public string? IchijitenCd { get; set; }

        [Column("ICHIJITEN_NM")]
        [Display(Name = "一次店名")]
        public string? IchijitenNm { get; set; }

        [Column("NIJITEN_CD")]
        [Display(Name = "二次店コード")]
        public string? NijitenCd { get; set; }

        [Column("NIJITEN_NM")]
        [Display(Name = "二次店名")]
        public string? NijitenNm { get; set; }

        [Column("TODOKESAKI_CD")]
        [Display(Name = "届先コード")]
        public string? TodokesakiCd { get; set; }

        [Column("TODOKESAKI_NM")]
        [Display(Name = "届先名")]
        public string? TodokesakiNm { get; set; }

        [Column("TODOKESAKI_GROUP_CD")]
        [Display(Name = "届先グループコード")]
        public string? TodokesakiGroupCd { get; set; }

        [Column("TODOKESAKI_GROUP_NM")]
        [Display(Name = "届先グループ名")]
        public string? TodokesakiGroupNm { get; set; }

        [Column("BOURBON_HONTEN_CD")]
        [Display(Name = "ブルボン本店コード")]
        public string? BourbonHontenCd { get; set; }

        [Column("BOURBON_ICHIJITEN_CD")]
        [Display(Name = "ブルボン一次店コード")]
        public string? BourbonIchijitenCd { get; set; }

        [Column("BOURBON_NIJITEN_CD")]
        [Display(Name = "ブルボン二次店コード")]
        public string? BourbonNijitenCd { get; set; }

        [Column("BOURBON_TODOKESAKI_CD")]
        [Display(Name = "ブルボン届先コード")]
        public string? BourbonTodokesakiCd { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "対象期間自")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "対象期間至")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("BOURBON_SHOHIN_CD")]
        [Display(Name = "ブルボン商品コード")]
        public string? BourbonShohinCd { get; set; }

        [Column("BOURBON_SHOHIN_CD_EDA")]
        [Display(Name = "ブルボン商品コード枝番")]
        public string? BourbonShohinCdEda { get; set; }

        [Column("BOURBON_SHOHIN_NM")]
        [Display(Name = "ブルボン商品名")]
        public string? BourbonShohinNm { get; set; }

        [Column("BARA_SOSU")]
        [Display(Name = "バラ総数")]
        public decimal? BaraSosu { get; set; }

        [Column("BOURBON_TATENE")]
        [Display(Name = "ブルボン建値")]
        public decimal? BourbonTatene { get; set; }

        [Column("TODOKE_HANBAI_TANKA")]
        [Display(Name = "届先販売単価")]
        public decimal? TodokeHanbaiTanka { get; set; }

        [Column("HANBAI_GOKEI_GAKU")]
        [Display(Name = "販売合計金額")]
        public decimal? HanbaiGokeiGaku { get; set; }

        [Column("TATENE_GOKEI_GAKU")]
        [Display(Name = "建値合計金額")]
        public decimal? TateneGokeiGaku { get; set; }

        [Column("MISEDASI_JUSIN_YMD")]
        [Display(Name = "店出受信日")]
        public string? MisedasiJusinYmd { get; set; }

        [Column("TORIKOMI_YMD")]
        [Display(Name = "取込日付")]
        public string? TorikomiYmd { get; set; }

        [Column("TORIKOMI_SINSEI_NO")]
        [Display(Name = "取込情報")]
        public string? TorikomiSinseiNo { get; set; }
    }
}