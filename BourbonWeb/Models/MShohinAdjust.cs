using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�[���������i�}�X�^")]
    public class MShohinAdjust
    {
        [Column("KY_SHOHIN_CD")]
        [Display(Name = "���iCD")]
        public string? KyShohinCd { get; set; }

        [Column("KY_SUB_CD")]
        [Display(Name = "�T�uCD")]
        public string? KySubCd { get; set; }

        [Column("KY_KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KyKaisiYmd { get; set; }

        [Column("KY_SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? KyShuryoYmd { get; set; }

        [Column("NAME_KANA")]
        [Display(Name = "���i���J�i")]
        public string? NameKana { get; set; }

        [Column("RYAKUSHO_KANA")]
        [Display(Name = "���̃J�i")]
        public string? RyakushoKana { get; set; }

        [Column("SHOHIN_NAME")]
        [Display(Name = "���i��")]
        public string? ShohinName { get; set; }

        [Column("RYAKUSHO_SYANAI")]
        [Display(Name = "�Г�����")]
        public string? RyakushoSyanai { get; set; }

        [Column("SHOHIN_YOTO")]
        [Display(Name = "���i�p�r")]
        public string? ShohinYoto { get; set; }

        [Column("JAN")]
        [Display(Name = "JANCD")]
        public string? Jan { get; set; }

        [Column("ITF")]
        [Display(Name = "ITFCD")]
        public string? Itf { get; set; }

        [Column("OYA_HINSHU")]
        [Display(Name = "�e�i��")]
        public string? OyaHinshu { get; set; }

        [Column("OYA_TINRETU")]
        [Display(Name = "�e��")]
        public string? OyaTinretu { get; set; }

        [Column("OYA_KIKAKU")]
        [Display(Name = "�e���")]
        public string? OyaKikaku { get; set; }

        [Column("OYA_YOBI")]
        [Display(Name = "�e�\��")]
        public string? OyaYobi { get; set; }

        [Column("DUMMY")]
        [Display(Name = "�_�~�[")]
        public string? Dummy { get; set; }

        [Column("SHOZOKU_BUNRUI")]
        [Display(Name = "��������")]
        public string? ShozokuBunrui { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "�c�ƕ���")]
        public string? EigyoBunrui { get; set; }

        [Column("INSATU_JUN")]
        [Display(Name = "�����")]
        public decimal? InsatuJun { get; set; }

        [Column("BUMON_BUNRUI")]
        [Display(Name = "���啪��")]
        public string? BumonBunrui { get; set; }

        [Column("UTIWAKE_BUNRUI")]
        [Display(Name = "���󕪗�")]
        public string? UtiwakeBunrui { get; set; }

        [Column("CATEGORY_BUNRUI1")]
        [Display(Name = "�J�e�S���[����1")]
        public string? CategoryBunrui1 { get; set; }

        [Column("CATEGORY_BUNRUI2")]
        [Display(Name = "�J�e�S���[����2")]
        public string? CategoryBunrui2 { get; set; }

        [Column("JICFS_BUNRUI")]
        [Display(Name = "JICFS����")]
        public string? JicfsBunrui { get; set; }

        [Column("SHOHIN_GROUP")]
        [Display(Name = "���i�O���[�v")]
        public string? ShohinGroup { get; set; }

        [Column("YOBI_BUNRUI1")]
        [Display(Name = "�\������1")]
        public string? YobiBunrui1 { get; set; }

        [Column("OPP_KBN")]
        [Display(Name = "OPP�敪")]
        public string? OppKbn { get; set; }

        [Column("KAKAKU_HYOJI")]
        [Display(Name = "���i�\��")]
        public string? KakakuHyoji { get; set; }

        [Column("HYOJUN_KAKAKU")]
        [Display(Name = "�\�����i")]
        public decimal? HyojunKakaku { get; set; }

        [Column("KIJUN_KAKAKU")]
        [Display(Name = "����i")]
        public decimal? KijunKakaku { get; set; }

        [Column("OROSI_KAKAKU")]
        [Display(Name = "�����i")]
        public decimal? OroshiKakaku { get; set; }

        [Column("KAKERITU1")]
        [Display(Name = "�|����1")]
        public decimal? Kakeritu1 { get; set; }

        [Column("KAKERITU2")]
        [Display(Name = "�|����2")]
        public decimal? Kakeritu2 { get; set; }

        [Column("KAZEI_KBN")]
        [Display(Name = "�ېŋ敪")]
        public string? KazeiKbn { get; set; }

        [Column("SHOHIZEI_RITU")]
        [Display(Name = "����ŗ�")]
        public decimal? ShohizeiRitu { get; set; }

        [Column("HANSOKU_KBN")]
        [Display(Name = "�̑��敪")]
        public string? HansokuKbn { get; set; }

        [Column("KEIHIN_KBN")]
        [Display(Name = "�i�i�敪")]
        public string? KeihinKbn { get; set; }

        [Column("R_TAISHO_KBN1")]
        [Display(Name = "�Ώۋ敪1")]
        public string? RTaishoKbn1 { get; set; }

        [Column("R_TAISHO_KBN2")]
        [Display(Name = "�Ώۋ敪2")]
        public string? RTaishoKbn2 { get; set; }

        [Column("SR_KBN")]
        [Display(Name = "SR�敪")]
        public string? SrKbn { get; set; }

        [Column("YOBI")]
        [Display(Name = "�\������1")]
        public string? Yobi { get; set; }

        [Column("RYO_HYOJI")]
        [Display(Name = "�ʕ\��")]
        public string? RyoHyoji { get; set; }

        [Column("RYO_TANI")]
        [Display(Name = "�ʒP��")]
        public string? RyoTani { get; set; }

        [Column("CASE_RYO")]
        [Display(Name = "�P�[�X��")]
        public decimal? CaseRyo { get; set; }

        [Column("BALL_RYO")]
        [Display(Name = "�{�[����")]
        public decimal? BallRyo { get; set; }

        [Column("UTIWAKE_KBN")]
        [Display(Name = "����敪")]
        public string? UtiwakeKbn { get; set; }

        [Column("SHOHIN_KIKAKU")]
        [Display(Name = "���i���i")]
        public string? ShohinKikaku { get; set; }

        [Column("VAN_KIKAKU")]
        [Display(Name = "VAN�K�i")]
        public string? VanKikaku { get; set; }

        [Column("KIKAKU_TANI")]
        [Display(Name = "�K�i�P��")]
        public string? KikakuTani { get; set; }

        [Column("HOSO_CASE")]
        [Display(Name = "��P�[�X")]
        public string? HosoCase { get; set; }

        [Column("HOSO_PEASE")]
        [Display(Name = "��s�[�X")]
        public string? HosoPease { get; set; }

        [Column("YOKI_CD")]
        [Display(Name = "�e��CD")]
        public string? YokiCd { get; set; }

        [Column("YOKI_KBN")]
        [Display(Name = "�e��敪")]
        public string? YokiKbn { get; set; }

        [Column("CASE_CHOHEN")]
        [Display(Name = "�P�[�X����")]
        public decimal? CaseChoHen { get; set; }

        [Column("CASE_TANHEN")]
        [Display(Name = "�P�[�X�Z��")]
        public decimal? CaseTanHen { get; set; }

        [Column("CASE_TAKASA")]
        [Display(Name = "�P�[�X����")]
        public decimal? CaseTakasa { get; set; }

        [Column("CASE_OMOSA")]
        [Display(Name = "�P�[�X�d��")]
        public decimal? CaseOmosa { get; set; }

        [Column("CASE_YOSEKI")]
        [Display(Name = "�P�[�X�e��")]
        public decimal? CaseYoseki { get; set; }

        [Column("BALL_TYOHEN")]
        [Display(Name = "�{�[������")]
        public decimal? BallTyohen { get; set; }

        [Column("BALL_TANHEN")]
        [Display(Name = "�{�[���Z��")]
        public decimal? BallTanhen { get; set; }

        [Column("BALL_TAKASA")]
        [Display(Name = "�{�[������")]
        public decimal? BallTakasa { get; set; }

        [Column("BALL_OMOSA")]
        [Display(Name = "�{�[���d��")]
        public decimal? BallOmosa { get; set; }

        [Column("BALL_YOSEKI")]
        [Display(Name = "�{�[���e��")]
        public decimal? BallYoseki { get; set; }

        [Column("PEASE_TYOHEN")]
        [Display(Name = "�s�[�X����")]
        public decimal? PeaseTyohen { get; set; }

        [Column("PEASE_TANHEN")]
        [Display(Name = "�s�[�X�Z��")]
        public decimal? PeaseTanhen { get; set; }

        [Column("PEASE_TAKASA")]
        [Display(Name = "�s�[�X����")]
        public decimal? PeaseTakasa { get; set; }

        [Column("PEASE_OMOSA")]
        [Display(Name = "�s�[�X�d��")]
        public decimal? PeaseOmosa { get; set; }

        [Column("PEASE_YOSEKI")]
        [Display(Name = "�s�[�X�e��")]
        public decimal? PeaseYoseki { get; set; }

        [Column("PALLET")]
        [Display(Name = "�p���b�g")]
        public string? Pallet { get; set; }

        [Column("MENSEKI")]
        [Display(Name = "�ʐ�")]
        public decimal? Menseki { get; set; }

        [Column("DANSU")]
        [Display(Name = "�i��")]
        public decimal? Dansu { get; set; }

        [Column("SAITEI_LOT")]
        [Display(Name = "�Œ�LOT")]
        public decimal? SaiteiLot { get; set; }

        [Column("YOBI_BUNRUI2")]
        [Display(Name = "�\������2")]
        public string? YobiBunrui2 { get; set; }

        [Column("NEKASE_KIKAN")]
        [Display(Name = "�Q��������")]
        public string? NekaseKikan { get; set; }

        [Column("HIZUKE_HYOJIKBN")]
        [Display(Name = "���t�\���敪")]
        public string? HizukeHyojikbn { get; set; }

        [Column("HIZUKE_INSATUKBN")]
        [Display(Name = "���t����敪")]
        public string? HizukeInsatukbn { get; set; }

        [Column("SHOMI_KBN")]
        [Display(Name = "�ܖ��敪")]
        public string? ShomiKbn { get; set; }

        [Column("SHOMI_KIKAN")]
        [Display(Name = "�ܖ�����")]
        public decimal? ShomiKikan { get; set; }

        [Column("TEION_KBN")]
        [Display(Name = "�ቷ�敪")]
        public string? TeionKbn { get; set; }

        [Column("TUMI_SOKO1")]
        [Display(Name = "�ϑq��1")]
        public string? TumiSoko1 { get; set; }

        [Column("TUMI_SOKO2")]
        [Display(Name = "�ϑq��2")]
        public string? TumiSoko2 { get; set; }

        [Column("SEISAN_KYUSIBI")]
        [Display(Name = "���Y�x�~��")]
        public string? SeisanKyusibi { get; set; }

        [Column("SEISAN_SAIKAIBI")]
        [Display(Name = "���Y�ĊJ��")]
        public string? SeisanSaikaibi { get; set; }

        [Column("HANKEN_YUKO_YMD")]
        [Display(Name = "�Ō��L���N����")]
        public string? HankenYukoYmd { get; set; }

        [Column("SEISAN_TYUSIBI")]
        [Display(Name = "���Y���~��")]
        public string? SeisanTyusibi { get; set; }

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

        [Column("PALLET_GTIN")]
        [Display(Name = "�p���b�gGTIN")]
        public string? PalletGtin { get; set; }

        [Column("PACK_GTIN")]
        [Display(Name = "�p�b�NGTIN")]
        public string? PackGtin { get; set; }

        [Column("CASE_GTIN")]
        [Display(Name = "�P�[�XGTIN")]
        public string? CaseGtin { get; set; }

        [Column("BALL_GTIN")]
        [Display(Name = "�{�[��GTIN")]
        public string? BallGtin { get; set; }

        [Column("CASE_GTIN_RYO")]
        [Display(Name = "�P�[�XGTIN��")]
        public decimal? CaseGtinRyo { get; set; }

        [Column("BALL_GTIN_RYO")]
        [Display(Name = "�{�[��GTIN��")]
        public decimal? BallGtinRyo { get; set; }

        [Column("GTIN_PACK_CASE")]
        [Display(Name = "GTIN�p�b�N�P�[�X")]
        public decimal? GtinPackCase { get; set; }

        [Column("GTIN_PACK_MODE_K")]
        [Display(Name = "GTIN�p�b�N���[�hK")]
        public string? GtinPackModeK { get; set; }

        [Column("GTIN_PACK_MODE_C")]
        [Display(Name = "GTIN�p�b�N���[�hC")]
        public string? GtinPackModeC { get; set; }

        [Column("GTIN_PACK_MODE_B")]
        [Display(Name = "GTIN�p�b�N���[�hB")]
        public string? GtinPackModeB { get; set; }

        [Column("GTIN_PACK_MODE_P")]
        [Display(Name = "GTIN�p�b�N���[�hP")]
        public string? GtinPackModeP { get; set; }

        [Column("GTIN_UCHIBAKO_ID")]
        [Display(Name = "GTIN����ID")]
        public string? GtinUchibakoId { get; set; }

        [Column("JAN_CASE")]
        [Display(Name = "�P�[�XJANCD")]
        public string? JanCase { get; set; }

        [Column("JAN_BALL")]
        [Display(Name = "�{�[��JANCD")]
        public string? JanBall { get; set; }

        [Column("HEAT_MAX")]
        [Display(Name = "�ő剷�x")]
        public decimal? HeatMax { get; set; }

        [Column("HEAT_MIN")]
        [Display(Name = "�ŏ����x")]
        public decimal? HeatMin { get; set; }

        [Column("HEAT_ID")]
        [Display(Name = "���xID")]
        public string? HeatId { get; set; }

        [Column("BRAND_ID")]
        [Display(Name = "�u�����hID")]
        public string? BrandId { get; set; }

        [Column("HANBAI_HONTEN")]
        [Display(Name = "�̔��{�X")]
        public string? HanbaiHonten { get; set; }

        [Column("CHANNEL1")]
        [Display(Name = "�`�����l��1")]
        public string? Channel1 { get; set; }

        [Column("CHANNEL2")]
        [Display(Name = "�`�����l��2")]
        public string? Channel2 { get; set; }

        [Column("CHANNEL3")]
        [Display(Name = "�`�����l��3")]
        public string? Channel3 { get; set; }

        [Column("FILELINK1")]
        [Display(Name = "�t�@�C�������N1")]
        public string? Filelink1 { get; set; }

        [Column("FILELINK2")]
        [Display(Name = "�t�@�C�������N2")]
        public string? Filelink2 { get; set; }

        [Column("FILELINK3")]
        [Display(Name = "�t�@�C�������N3")]
        public string? Filelink3 { get; set; }

        [Column("IMAGELINK")]
        [Display(Name = "�C���[�W�����N")]
        public string? Imagelink { get; set; }

        [Column("NAME_ENGLISH")]
        [Display(Name = "���i��(�p��)")]
        public string? NameEnglish { get; set; }

        [Column("CARE_ID")]
        [Display(Name = "�P�AID")]
        public string? CareId { get; set; }

        [Column("GROUP_SHOHIN_CD")]
        [Display(Name = "�O���[�v���iCD")]
        public string? GroupShohinCd { get; set; }

        [Column("GROUP_CATEGORY_CD")]
        [Display(Name = "�O���[�v�J�e�S���[CD")]
        public string? GroupCategoryCd { get; set; }

        [Column("GROUP_BUMON_CD")]
        [Display(Name = "�O���[�v����CD")]
        public string? GroupBumonCd { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "��ю��Y�敪")]
        public string? IttaiSisanKbn { get; set; }

        [Column("SHOHIZEI_KBN")]
        [Display(Name = "����ŋ敪")]
        public string? ShohizeiKbn { get; set; }

        [Column("RICE_TRACEABILITY_KBN")]
        [Display(Name = "�ăg���[�T�r���e�B�敪")]
        public string? RiceTraceabilityKbn { get; set; }

        [Column("RICE_TRACEABILITY_TRN")]
        [Display(Name = "�ăg���[�T�r���e�B�g����")]
        public string? RiceTraceabilityTrn { get; set; }

        [Column("HATUBAIBI")]
        [Display(Name = "������")]
        public string? Hatubaibi { get; set; }

        [Column("KOURI_CD")]
        [Display(Name = "����CD")]
        public string? KouriCd { get; set; }

        [Column("CATEGORY_BUNRUI1_NM")]
        [Display(Name = "�J�e�S���[����1����")]
        public string? CategoryBunrui1Nm { get; set; }

        [Column("CATEGORY_BUNRUI2_NM")]
        [Display(Name = "�J�e�S���[����2����")]
        public string? CategoryBunrui2Nm { get; set; }


    }
}