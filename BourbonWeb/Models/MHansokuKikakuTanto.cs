using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑����S���}�X�^")]
    public class MHansokuKikakuTanto
    {
        [Column("TANTO_SHO_CD")]
        [Display(Name = "�쐬�S�����R�[�h")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_KAISI_YM")]
        [Display(Name = "�S���J�n�N��")]
        public string? TantoKaisiYm { get; set; }

        [Column("TANTO_SHURYO_YM")]
        [Display(Name = "�S���I���N��")]
        public string? TantoShuryoYm { get; set; }

        [Column("TANTO_TOKUI_CD")]
        [Display(Name = "�S�����Ӑ�R�[�h")]
        public string? TantoTokuiCd { get; set; }

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