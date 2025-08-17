using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑������e�}�X�^")]
    public class MHansokuNaiyou
    {
        [Column("KY_KBN_SIKIBETU_CD")]
        [Display(Name = "�敪����CD")]
        public string? KyKbnSikibetuCd { get; set; }

        [Column("KY_KBN_CD")]
        [Display(Name = "�敪CD")]
        public string? KyKbnCd { get; set; }

        [Column("HANSOKU_NAIYOU_NAME")]
        [Display(Name = "�̑����e��")]
        public string? HansokuNaiyouName { get; set; }

        [Column("HANSOKU_NAIYOU_ORDER")]
        [Display(Name = "�̑����e�\�[�g��")]
        public short? HansokuNaiyouOrder { get; set; }

        [Column("HANSOKU_NAIYOU_HYOJI")]
        [Display(Name = "�̑����e�\��")]
        public bool? HansokuNaiyouHyoji { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "����T������")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "�o���")]
        public string? KeihiBunrui { get; set; }

        [Column("REMARKS1")]
        [Display(Name = "���l1")]
        public string? Remarks1 { get; set; }

        [Column("REMARKS2")]
        [Display(Name = "���l2")]
        public string? Remarks2 { get; set; }

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

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "�ŗ��敪")]
        public string? ZeiRituKbn { get; set; }

    }
}