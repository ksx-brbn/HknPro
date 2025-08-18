using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\���Ӓ������")]
    public class THansokuSinseiKagamiChosei
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

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "�\���Ӕԍ�")]
        public string? SinseiKagamiNo { get; set; }

        [Column("ZEI_RITU")]
        [Display(Name = "�ŗ�")]
        public decimal? ZeiRitu { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "�ŗ��敪")]
        public string? ZeiRituKbn { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "���^�z")]
        public decimal? KyosanGaku { get; set; }

        [Column("ZEI_GAKU")]
        [Display(Name = "�Ŋz")]
        public decimal? ZeiGaku { get; set; }

        [Column("ZEI_GAKU_CHOSEI")]
        [Display(Name = "�Ŋz����")]
        public decimal? ZeiGakuChosei { get; set; }

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

        [Column("LOCK_VERSION")]
        [Display(Name = "���b�N�o�[�W����")]
        public int? LockVersion { get; set; }
    }
}