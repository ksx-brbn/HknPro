using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\����ږ���")]
    public class THansokuSinseiHimoku
    {
        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "���|����")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SINSEI_NO")]
        [Display(Name = "�\���ԍ�")]
        public string? SinseiNo { get; set; }

        [Column("SINSEI_GYO_NO")]
        [Display(Name = "�\���s�ԍ�")]
        public short? SinseiGyoNo { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "�`�[�敪")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "�̑��敪")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "�̑��敪�ڍ�")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "�̑��敪��")]
        public string? HansokKbnKobetu { get; set; }

        [Column("HANSOK_HIMOKU_NM_A")]
        [Display(Name = "�̑���ڕʖ�A")]
        public string? HansokHimokuNmA { get; set; }

        [Column("HANSOK_HIMOKU_NM_B")]
        [Display(Name = "�̑���ڕʖ�B")]
        public string? HansokHimokuNmB { get; set; }

        [Column("HANSOK_HIMOKU_ORDER")]
        [Display(Name = "�̑���̕\����")]
        public int? HansokHimokuOrder { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "���^����")]
        public decimal? KyosanJoken { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "���^�z")]
        public decimal? KyosanGaku { get; set; }

        [Column("KYOSAN_GAKU_CHOSEI")]
        [Display(Name = "���^�z����")]
        public decimal? KyosanGakuChosei { get; set; }

        [Column("KYOSAN_GAKU_ZEI_KBN")]
        [Display(Name = "���^�z����ŋ敪")]
        public string? KyosanGakuZeiKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "���^�z����Ŋz")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("AREA_TAISHO_YM")]
        [Display(Name = "�G���A�E�Ώ۔N��")]
        public string? AreaTaishoYm { get; set; }

        [Column("AREA_HANSOKU_KBN")]
        [Display(Name = "�G���A�E�̑��敪")]
        public string? AreaHansokuKbn { get; set; }

        [Column("AREA_HANSOKU_KBN_SHOSAI")]
        [Display(Name = "�G���A�E�̑��敪�ڍ�")]
        public string? AreaHansokuKbnShosai { get; set; }

        [Column("AREA_SHO_CD")]
        [Display(Name = "�G���A�E�S�����R�[�h")]
        public string? AreaShoCd { get; set; }

        [Column("AREA_SALES_CD")]
        [Display(Name = "�G���A�E�S���҃R�[�h")]
        public string? AreaSalesCd { get; set; }

        [Column("AREA_TOKUI_CD")]
        [Display(Name = "�G���A�E���Ӑ�R�[�h")]
        public string? AreaTokuiCd { get; set; }

        [Column("AREA_KOBETU_CD")]
        [Display(Name = "�G���A�E�ʃR�[�h")]
        public string? AreaKobetuCd { get; set; }

        [Column("NEBK_DENPYO_NO")]
        [Display(Name = "���|�l���`�[�ԍ�")]
        public string? NebkDenpyoNo { get; set; }

        [Column("NEBK_GAITOU_DATE")]
        [Display(Name = "���|�l���Y���N��")]
        public string? NebkGaitouDate { get; set; }

        [Column("NEBK_SEIKYU_KBN")]
        [Display(Name = "���|�l�������敪")]
        public string? NebkSeikyuKbn { get; set; }

        [Column("NEBK_SHOP_CD")]
        [Display(Name = "���|�l��������R�[�h")]
        public string? NebkShopCd { get; set; }

        [Column("NEBK_RENKEI_DATE")]
        [Display(Name = "���|�A�g����")]
        public DateTime? NebkRenkeiDate { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "�o�^��")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "�o�^��")]
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

        [Column("SHOHIZEI_RITU")]
        [Display(Name = "����ŗ�")]
        public decimal? ShohizeiRitu { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "�ŗ��敪")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "��ю��Y�敪")]
        public string? IttaiSisanKbn { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "�o���")]
        public string? KeihiBunrui { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "����T������")]
        public string? UriageKoujyoHantei { get; set; }
    }
}