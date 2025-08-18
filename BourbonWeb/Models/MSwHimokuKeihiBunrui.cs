using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "��ڌo��ރ}�X�^")]
    public class MSwHimokuKeihiBunrui
    {
        [Column("SYSTEM_KBN")]
        [Display(Name = "�V�X�e���敪")]
        public string? SystemKbn { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

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

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "�ΏۊJ�n�N��")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "�ΏۏI���N��")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("KEIHI_BUNRUI_CD")]
        [Display(Name = "�o���CD")]
        public string? KeihiBunruiCd { get; set; }

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