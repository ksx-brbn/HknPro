using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���斾�׃}�X�^")]
    public class MHansokuKikakuMeisai
    {
        [Column("HANSOK_KIKAKU_CD")]
        [Display(Name = "�̑����R�[�h")]
        public string? HansokKikakuCd { get; set; }

        [Column("HANSOK_KIKAKU_GYO_NO")]
        [Display(Name = "�̑����s�ԍ�")]
        public short? HansokKikakuGyoNo { get; set; }

        [Column("TOZAI_KBN")]
        [Display(Name = "�����敪")]
        public string? TozaiKbn { get; set; }

        [Column("HIMOKU_CD")]
        [Display(Name = "��ڃR�[�h")]
        public string? HimokuCd { get; set; }

        [Column("HIMOKU_NM")]
        [Display(Name = "��ږ�")]
        public string? HimokuNm { get; set; }

        [Column("SAVE_FLG")]
        [Display(Name = "�ۑ��t���O")]
        public string? SaveFlg { get; set; }

        [Column("MEISAI_CD_KBN")]
        [Display(Name = "���׃R�[�h�敪")]
        public string? MeisaiCdKbn { get; set; }

        [Column("MEISAI_CD")]
        [Display(Name = "���׃R�[�h")]
        public string? MeisaiCd { get; set; }

        [Column("SHOHIN_NM")]
        [Display(Name = "���i��")]
        public string? ShohinNm { get; set; }

        [Column("EIGYO_BUNURI")]
        [Display(Name = "�c�ƕ���")]
        public string? EigyoBunuri { get; set; }

        [Column("CATEGORY_MEISAI")]
        [Display(Name = "�J�e�S������")]
        public string? CategoryMeisai { get; set; }

        [Column("SR_KBN")]
        [Display(Name = "SR�敪")]
        public string? SrKbn { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SHOHIN_SURYO")]
        [Display(Name = "���i����")]
        public string? ShohinSuryo { get; set; }

        [Column("CASE_RYO")]
        [Display(Name = "�P�[�X��")]
        public decimal? CaseRyo { get; set; }

        [Column("BALL_RYO")]
        [Display(Name = "�{�[����")]
        public decimal? BallRyo { get; set; }

        [Column("TATENE")]
        [Display(Name = "���l")]
        public decimal? Tatene { get; set; }

        [Column("TANKA")]
        [Display(Name = "�P��")]
        public decimal? Tanka { get; set; }

        [Column("KETTYAKU_TANKA")]
        [Display(Name = "�����P��")]
        public decimal? KettyakuTanka { get; set; }

        [Column("TATENE_NEBIKI_RITU")]
        [Display(Name = "���l�l����")]
        public decimal? TateneNebikiRitu { get; set; }

        [Column("TATENE_NEBIKI_RITU_WITHOUT_REBETE")]
        [Display(Name = "���l�l����_���x�[�g����")]
        public decimal? TateneNebikiRituWithoutRebete { get; set; }

        [Column("TATENE_NEBIKI_GAKU")]
        [Display(Name = "���l�l���z")]
        public decimal? TateneNebikiGaku { get; set; }

        [Column("TATENE_NEBIKI_GAKU_WITHOUT_REBETE")]
        [Display(Name = "���l�l���z_���x�[�g����")]
        public decimal? TateneNebikiGakuWithoutRebete { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "���^����")]
        public decimal? KyosanJoken { get; set; }

        [Column("TONYA_HAKIDASI_RITU")]
        [Display(Name = "�≮�f�o��")]
        public decimal? TonyaHakidasiRitu { get; set; }

        [Column("TONYA_HAKIDASI_GAKU")]
        [Display(Name = "�≮�f�o�z")]
        public decimal? TonyaHakidasiGaku { get; set; }

        [Column("GENBUTU_JOKEN_FLG")]
        [Display(Name = "���������t���O")]
        public bool? GenbutuJokenFlg { get; set; }

        [Column("GENBUTU_JOKEN_URIAGE")]
        [Display(Name = "��������_����")]
        public int? GenbutuJokenUriage { get; set; }

        [Column("GENBUTU_JOKEN_SERVICE")]
        [Display(Name = "��������_�T�[�r�X")]
        public int? GenbutuJokenService { get; set; }

        [Column("SURYO_JOKEN_FLG")]
        [Display(Name = "���ʏ����t���O")]
        public bool? SuryoJokenFlg { get; set; }

        [Column("SURYO_JOKEN_MIN")]
        [Display(Name = "���ʏ����ŏ�")]
        public int? SuryoJokenMin { get; set; }

        [Column("SURYO_JOKEN_MAX")]
        [Display(Name = "���ʏ����ő�")]
        public int? SuryoJokenMax { get; set; }

        [Column("MITUMORI_JOKEN_SIYO_FLG")]
        [Display(Name = "���Ϗ����g�p�t���O")]
        public bool? MitumoriJokenSiyoFlg { get; set; }

        [Column("HANSOK_HIMOKU_ORDER")]
        [Display(Name = "�̑���ڕ\����")]
        public short? HansokHimokuOrder { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "�o�^��")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "�쐬��")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "�X�V��")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "�X�V��")]
        public DateTime? UpdatedAt { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "�폜�t���O")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "���b�N�o�[�W����")]
        public int? LockVersion { get; set; }

        [Column("BAIKA")]
        [Display(Name = "����")]
        public decimal? Baika { get; set; }

        [Column("BARA_SURYO")]
        [Display(Name = "�o������")]
        public decimal? BaraSuryo { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "����T������")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("HANSOKU_NAIYOU")]
        [Display(Name = "�̑����e")]
        public string? HansokuNaiyou { get; set; }

        [Column("JIZEN_SINSEI_HIMOKU_CD")]
        [Display(Name = "���O�\����ڃR�[�h")]
        public string? JizenSinseiHimokuCd { get; set; }

        [Column("TAISHO_KINGAKU")]
        [Display(Name = "�Ώۋ��z")]
        public decimal? TaishoKingaku { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "���^�z")]
        public decimal? KyosanGaku { get; set; }

        [Column("MEISAI_SUB_CD")]
        [Display(Name = "���׃T�u�R�[�h")]
        public string? MeisaiSubCd { get; set; }
    }
}