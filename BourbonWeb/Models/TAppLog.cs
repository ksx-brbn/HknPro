using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�A�v���P�[�V�������O")]
    public class TAppLog
    {
        [Column("ID")]
        [Display(Name = "ID")]
        public long? Id { get; set; }

        [Column("LOG_LEVEL")]
        [Display(Name = "���O���x��")]
        public string? LogLevel { get; set; }

        [Column("PROGRAM_ID")]
        [Display(Name = "�v���O����ID")]
        public string? ProgramId { get; set; }

        [Column("PROCEDURE_ID")]
        [Display(Name = "�v���V�[�W��ID")]
        public string? ProcedureId { get; set; }

        [Column("IP_ADDRESS")]
        [Display(Name = "IP�A�h���X")]
        public string? IpAddress { get; set; }

        [Column("LOGIN_SHO_CD")]
        [Display(Name = "���O�C����CD")]
        public string? LoginShoCd { get; set; }

        [Column("LOGIN_SHO_NM")]
        [Display(Name = "���O�C������")]
        public string? LoginShoNm { get; set; }

        [Column("LOGIN_SHA_CD")]
        [Display(Name = "���O�C����CD")]
        public string? LoginShaCd { get; set; }

        [Column("LOGIN_SHA_NM")]
        [Display(Name = "���O�C���Җ�")]
        public string? LoginShaNm { get; set; }

        [Column("MESSAGE")]
        [Display(Name = "���b�Z�[�W")]
        public string? Message { get; set; }

        [Column("STACK_TRACE")]
        [Display(Name = "�X�^�b�N�g���[�X")]
        public string? StackTrace { get; set; }

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