using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "��ƃO���[�v�}�X�^")]
    public class MGroupCompany
    {
        [Column("GROUP_KBN")]
        [Display(Name = "�O���[�v�敪")]
        public string? GroupKbn { get; set; }

        [Column("GROUP_CD")]
        [Display(Name = "�O���[�vCD")]
        public string? GroupCd { get; set; }

        [Column("KAISI_YM")]
        [Display(Name = "�Ώۊ��ԊJ�n�N��")]
        public string? KaisiYm { get; set; }

        [Column("SHURYO_YM")]
        [Display(Name = "�Ώۊ��ԏI���N��")]
        public string? ShuryoYm { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("MISE_CD")]
        [Display(Name = "�XCD")]
        public string? MiseCd { get; set; }

        [Column("MISE_NM")]
        [Display(Name = "�X��")]
        public string? MiseNm { get; set; }

        [Column("ORDER_NO")]
        [Display(Name = "�\����")]
        public short? OrderNo { get; set; }

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
    }
}