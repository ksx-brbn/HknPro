using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\����t���")]
    public class THansokuSinseiUketuke
    {
        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "�\���ӈÍ�")]
        public string? SinseiKagamiNo { get; set; }

        [Column("UKETUKE_NO")]
        [Display(Name = "��t�ԍ�")]
        public string? UketukeNo { get; set; }

        [Column("UKETUKE_NITIJI")]
        [Display(Name = "��t����")]
        public DateTime? UketukeNitiji { get; set; }

        [Column("UKETUKE_SHOZOKU_CD")]
        [Display(Name = "��t�����R�[�h")]
        public string? UketukeShozokuCd { get; set; }

        [Column("UKETUKE_SHOZOKU_NM")]
        [Display(Name = "��t������")]
        public string? UketukeShozokuNm { get; set; }

        [Column("UKETUKE_SHA_CD")]
        [Display(Name = "��t�҃R�[�h")]
        public string? UketukeShaCd { get; set; }

        [Column("UKETUKE_SHA_NM")]
        [Display(Name = "��t�Җ�")]
        public string? UketukeShaNm { get; set; }

        [Column("UKETUKE_KIGOU")]
        [Display(Name = "��t�L��")]
        public string? UketukeKigou { get; set; }

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