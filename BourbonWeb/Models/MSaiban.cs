using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̔ԊǗ��}�X�^")]
    public class MSaiban
    {
        [Column("NO_KBN")]
        [Display(Name = "�ԍ��敪")]
        public string? NoKbn { get; set; }

        [Column("KAISI_NO")]
        [Display(Name = "�J�n�ԍ�")]
        public int? KaisiNo { get; set; }

        [Column("GENZAI_NO")]
        [Display(Name = "���ݔԍ�")]
        public int? GenzaiNo { get; set; }

        [Column("SAISHU_NO")]
        [Display(Name = "�ŏI�ԍ�")]
        public int? SaishuNo { get; set; }

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