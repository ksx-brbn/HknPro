using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "営業所マスタ")]
    public class Meigyo
    {
        [Column("KY_SHO_CD")]
        [Display(Name = "所CD")]
        public string? KyShoCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? KyShuryoYmd { get; set; }

        [Column("SHO_NM")]
        [Display(Name = "所名")]
        public string? ShoNm { get; set; }

        [Column("SHO_NM_KANA")]
        [Display(Name = "所名カナ")]
        public string? ShoNmKana { get; set; }

        [Column("KEN_NM")]
        [Display(Name = "県")]
        public string? KenNm { get; set; }

        [Column("SICHOSON_NM")]
        [Display(Name = "市町村")]
        public string? SichosonNm { get; set; }

        [Column("JUSHO_KANA")]
        [Display(Name = "住所カナ")]
        public string? JushoKana { get; set; }

        [Column("SICHOSON_CD")]
        [Display(Name = "市町村CD")]
        public string? SichosonCd { get; set; }

        [Column("YUBIN_UE")]
        [Display(Name = "郵便(上)")]
        public string? YubinUe { get; set; }

        [Column("YUBIN_SITA")]
        [Display(Name = "郵便(下)")]
        public string? YubinSita { get; set; }

        [Column("TEL_NO1")]
        [Display(Name = "電話番号1")]
        public string? TelNo1 { get; set; }

        [Column("TEL_NO2")]
        [Display(Name = "電話番号2")]
        public string? TelNo2 { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "FAX")]
        public string? FaxNo { get; set; }

        [Column("TANMATU_TEL_NO")]
        [Display(Name = "端末電話番号")]
        public string? TanmatuTelNo { get; set; }

        [Column("CHIIKI_BUNRUI")]
        [Display(Name = "地域分類")]
        public string? ChiikiBunrui { get; set; }

        [Column("KODO_BUNRUI")]
        [Display(Name = "行動分類")]
        public string? KodoBunrui { get; set; }

        [Column("SHO_BUNRUI")]
        [Display(Name = "所分類")]
        public string? ShoBunrui { get; set; }

        [Column("BUTURYU_ID")]
        [Display(Name = "物流ID")]
        public string? ButuryuId { get; set; }

        [Column("KAISETU_YMD")]
        [Display(Name = "開設年月日")]
        public string? KaisetuYmd { get; set; }

        [Column("HEISA_YMD")]
        [Display(Name = "閉鎖年月日")]
        public string? HeisaYmd { get; set; }

        [Column("SHUKA_SOKO_CD")]
        [Display(Name = "出荷倉庫CD")]
        public string? ShukaSokoCd { get; set; }

        [Column("KAISETUMAE_SHO_CD")]
        [Display(Name = "開設前所CD")]
        public string? KaisetumaeShoCd { get; set; }

        [Column("HEISAGO_SHO_CD")]
        [Display(Name = "閉鎖後所CD")]
        public string? HeisagoShoCd { get; set; }

        [Column("EIGYO_SHO_CD")]
        [Display(Name = "営業所CD")]
        public string? EigyoShoCd { get; set; }

        [Column("EIGYO_SHO_NM")]
        [Display(Name = "営業所名")]
        public string? EigyoShoNm { get; set; }

        [Column("HUKU_EIGYO_SHO_CD")]
        [Display(Name = "副営業所CD")]
        public string? HukuEigyoShoCd { get; set; }

        [Column("HUKU_EIGYO_SHO_NM")]
        [Display(Name = "副営業所名")]
        public string? HukuEigyoShoNm { get; set; }

        [Column("SHOKEN_CD")]
        [Display(Name = "証券CD")]
        public string? ShokenCd { get; set; }

        [Column("SHOKEN_NM")]
        [Display(Name = "証券名")]
        public string? ShokenNm { get; set; }

        [Column("KANKATU_SHUKEI_CD")]
        [Display(Name = "管轄集計CD")]
        public string? KankatuShukeiCd { get; set; }

        [Column("SEIKA_SHUKEI_CD")]
        [Display(Name = "成果集計CD")]
        public string? SeikaShukeiCd { get; set; }

        [Column("SONEKI_KEISAN_CD")]
        [Display(Name = "損益計算CD")]
        public string? SonekiKeisanCd { get; set; }

        [Column("KOGUCHI_KANRI_CD")]
        [Display(Name = "小口管理CD")]
        public string? KoguchiKanriCd { get; set; }

        [Column("BUTURYU_ZAISEKI_CD")]
        [Display(Name = "物流在籍CD")]
        public string? ButuryuZaisekiCd { get; set; }

        [Column("PRINT_JUN")]
        [Display(Name = "印刷順")]
        public decimal? PrintJun { get; set; }

        [Column("EIGYO_SHOCHO_CD")]
        [Display(Name = "営業所長CD")]
        public string? EigyoShochoCd { get; set; }

        [Column("EIGYO_SHOCHO_DAIRI_CD")]
        [Display(Name = "営業所長代理CD")]
        public string? EigyoShochoDairiCd { get; set; }

        [Column("SHOCHO_CD")]
        [Display(Name = "所長CD")]
        public string? ShochoCd { get; set; }

        [Column("SHOCHO_DAIRI_CD")]
        [Display(Name = "所長代理CD")]
        public string? ShochoDairiCd { get; set; }

        [Column("KANKATU_SU")]
        [Display(Name = "管轄数")]
        public decimal? KankatuSu { get; set; }

        [Column("SALES_SU")]
        [Display(Name = "営業数")]
        public decimal? SalesSu { get; set; }

        [Column("TANTO_JINKO")]
        [Display(Name = "担当人口")]
        public decimal? TantoJinko { get; set; }

        [Column("URITAN_SALES_CD")]
        [Display(Name = "売担当者CD")]
        public string? UritanSalesCd { get; set; }

        [Column("SHOTAN_SALES_CD")]
        [Display(Name = "所担当者CD")]
        public string? ShotanSalesCd { get; set; }

        [Column("TANMATU_UMU")]
        [Display(Name = "端末有無")]
        public string? TanmatuUmu { get; set; }

        [Column("TANMATU_ID")]
        [Display(Name = "端末ID")]
        public string? TanmatuId { get; set; }

        [Column("GENURI_CD")]
        [Display(Name = "現売CD")]
        public string? GenuriCd { get; set; }

        [Column("KOURI_CD")]
        [Display(Name = "小売CD")]
        public string? KouriCd { get; set; }

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

        [Column("HATUBAI_GROUP")]
        [Display(Name = "配信グループ")]
        public string? HatubaiGroup { get; set; }

    }
}