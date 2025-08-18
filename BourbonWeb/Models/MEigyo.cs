using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�c�Ə��}�X�^")]
    public class Meigyo
    {
        [Column("KY_SHO_CD")]
        [Display(Name = "��CD")]
        public string? KyShoCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? KyShuryoYmd { get; set; }

        [Column("SHO_NM")]
        [Display(Name = "����")]
        public string? ShoNm { get; set; }

        [Column("SHO_NM_KANA")]
        [Display(Name = "�����J�i")]
        public string? ShoNmKana { get; set; }

        [Column("KEN_NM")]
        [Display(Name = "��")]
        public string? KenNm { get; set; }

        [Column("SICHOSON_NM")]
        [Display(Name = "�s����")]
        public string? SichosonNm { get; set; }

        [Column("JUSHO_KANA")]
        [Display(Name = "�Z���J�i")]
        public string? JushoKana { get; set; }

        [Column("SICHOSON_CD")]
        [Display(Name = "�s����CD")]
        public string? SichosonCd { get; set; }

        [Column("YUBIN_UE")]
        [Display(Name = "�X��(��)")]
        public string? YubinUe { get; set; }

        [Column("YUBIN_SITA")]
        [Display(Name = "�X��(��)")]
        public string? YubinSita { get; set; }

        [Column("TEL_NO1")]
        [Display(Name = "�d�b�ԍ�1")]
        public string? TelNo1 { get; set; }

        [Column("TEL_NO2")]
        [Display(Name = "�d�b�ԍ�2")]
        public string? TelNo2 { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "FAX")]
        public string? FaxNo { get; set; }

        [Column("TANMATU_TEL_NO")]
        [Display(Name = "�[���d�b�ԍ�")]
        public string? TanmatuTelNo { get; set; }

        [Column("CHIIKI_BUNRUI")]
        [Display(Name = "�n�敪��")]
        public string? ChiikiBunrui { get; set; }

        [Column("KODO_BUNRUI")]
        [Display(Name = "�s������")]
        public string? KodoBunrui { get; set; }

        [Column("SHO_BUNRUI")]
        [Display(Name = "������")]
        public string? ShoBunrui { get; set; }

        [Column("BUTURYU_ID")]
        [Display(Name = "����ID")]
        public string? ButuryuId { get; set; }

        [Column("KAISETU_YMD")]
        [Display(Name = "�J�ݔN����")]
        public string? KaisetuYmd { get; set; }

        [Column("HEISA_YMD")]
        [Display(Name = "���N����")]
        public string? HeisaYmd { get; set; }

        [Column("SHUKA_SOKO_CD")]
        [Display(Name = "�o�בq��CD")]
        public string? ShukaSokoCd { get; set; }

        [Column("KAISETUMAE_SHO_CD")]
        [Display(Name = "�J�ݑO��CD")]
        public string? KaisetumaeShoCd { get; set; }

        [Column("HEISAGO_SHO_CD")]
        [Display(Name = "���㏊CD")]
        public string? HeisagoShoCd { get; set; }

        [Column("EIGYO_SHO_CD")]
        [Display(Name = "�c�Ə�CD")]
        public string? EigyoShoCd { get; set; }

        [Column("EIGYO_SHO_NM")]
        [Display(Name = "�c�Ə���")]
        public string? EigyoShoNm { get; set; }

        [Column("HUKU_EIGYO_SHO_CD")]
        [Display(Name = "���c�Ə�CD")]
        public string? HukuEigyoShoCd { get; set; }

        [Column("HUKU_EIGYO_SHO_NM")]
        [Display(Name = "���c�Ə���")]
        public string? HukuEigyoShoNm { get; set; }

        [Column("SHOKEN_CD")]
        [Display(Name = "�،�CD")]
        public string? ShokenCd { get; set; }

        [Column("SHOKEN_NM")]
        [Display(Name = "�،���")]
        public string? ShokenNm { get; set; }

        [Column("KANKATU_SHUKEI_CD")]
        [Display(Name = "�Ǌ��W�vCD")]
        public string? KankatuShukeiCd { get; set; }

        [Column("SEIKA_SHUKEI_CD")]
        [Display(Name = "���ʏW�vCD")]
        public string? SeikaShukeiCd { get; set; }

        [Column("SONEKI_KEISAN_CD")]
        [Display(Name = "���v�v�ZCD")]
        public string? SonekiKeisanCd { get; set; }

        [Column("KOGUCHI_KANRI_CD")]
        [Display(Name = "�����Ǘ�CD")]
        public string? KoguchiKanriCd { get; set; }

        [Column("BUTURYU_ZAISEKI_CD")]
        [Display(Name = "�����ݐ�CD")]
        public string? ButuryuZaisekiCd { get; set; }

        [Column("PRINT_JUN")]
        [Display(Name = "�����")]
        public decimal? PrintJun { get; set; }

        [Column("EIGYO_SHOCHO_CD")]
        [Display(Name = "�c�Ə���CD")]
        public string? EigyoShochoCd { get; set; }

        [Column("EIGYO_SHOCHO_DAIRI_CD")]
        [Display(Name = "�c�Ə����㗝CD")]
        public string? EigyoShochoDairiCd { get; set; }

        [Column("SHOCHO_CD")]
        [Display(Name = "����CD")]
        public string? ShochoCd { get; set; }

        [Column("SHOCHO_DAIRI_CD")]
        [Display(Name = "�����㗝CD")]
        public string? ShochoDairiCd { get; set; }

        [Column("KANKATU_SU")]
        [Display(Name = "�Ǌ���")]
        public decimal? KankatuSu { get; set; }

        [Column("SALES_SU")]
        [Display(Name = "�c�Ɛ�")]
        public decimal? SalesSu { get; set; }

        [Column("TANTO_JINKO")]
        [Display(Name = "�S���l��")]
        public decimal? TantoJinko { get; set; }

        [Column("URITAN_SALES_CD")]
        [Display(Name = "���S����CD")]
        public string? UritanSalesCd { get; set; }

        [Column("SHOTAN_SALES_CD")]
        [Display(Name = "���S����CD")]
        public string? ShotanSalesCd { get; set; }

        [Column("TANMATU_UMU")]
        [Display(Name = "�[���L��")]
        public string? TanmatuUmu { get; set; }

        [Column("TANMATU_ID")]
        [Display(Name = "�[��ID")]
        public string? TanmatuId { get; set; }

        [Column("GENURI_CD")]
        [Display(Name = "����CD")]
        public string? GenuriCd { get; set; }

        [Column("KOURI_CD")]
        [Display(Name = "����CD")]
        public string? KouriCd { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "�o�^�N����")]
        public string? TorokuYmd { get; set; }

        [Column("TOROKU_TIME")]
        [Display(Name = "�o�^����")]
        public string? TorokuTime { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "�폜�t���O")]
        public string? DeleteFlg { get; set; }

        [Column("HAISIN_FLG")]
        [Display(Name = "�z�M�t���O")]
        public string? HaisinFlg { get; set; }

        [Column("HAISIN_YMD")]
        [Display(Name = "�z�M�N����")]
        public string? HaisinYmd { get; set; }

        [Column("HATUBAI_GROUP")]
        [Display(Name = "�z�M�O���[�v")]
        public string? HatubaiGroup { get; set; }

    }
}