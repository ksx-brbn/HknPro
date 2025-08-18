using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�����Ǘ��}�X�^")]
    public class MSimebiKanri
    {
        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("KANRI_KBN")]
        [Display(Name = "�Ǘ��敪")]
        public string? KanriKbn { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "�Ώۊ��ԊJ�n��")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "�Ώۊ��ԏI����")]
        public string? TaishoShuryoYmd { get; set; }

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