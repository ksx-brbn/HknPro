using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�o��z�����")]
    public class TSkKeihiHaibun
    {
        [Column("SINSEI_NO")]
        [Display(Name = "�\���ԍ�")]
        public string? SinseiNo { get; set; }

        [Column("KEIHI_SHO_CD")]
        [Display(Name = "�o�CD")]
        public string? KeihiShoCd { get; set; }

        [Column("KEIHI_SHO_NM")]
        [Display(Name = "�o�")]
        public string? KeihiShoNm { get; set; }

        [Column("KEIHI_SHA_CD")]
        [Display(Name = "�o���CD")]
        public string? KeihiShaCd { get; set; }

        [Column("KEIHI_SHA_NM")]
        [Display(Name = "�o���")]
        public string? KeihiShaNm { get; set; }

        [Column("HAIBUN_LEVEL")]
        [Display(Name = "�z�����x��")]
        public string? HaibunLevel { get; set; }

        [Column("JOKEN_KBN")]
        [Display(Name = "�����敪")]
        public string? JokenKbn { get; set; }

        [Column("JOKEN_KBN_NM")]
        [Display(Name = "�����敪��")]
        public string? JokenKbnNm { get; set; }

        [Column("HASU_CHOSEI_SHO_FLG")]
        [Display(Name = "�[��������")]
        public bool? HasuChoseiShoFlg { get; set; }

        [Column("HAIBUN_JOKEN_HYOJI")]
        [Display(Name = "���z�����\��")]
        public decimal? HaibunJokenHyoji { get; set; }

        [Column("HAIBUN_JOKEN")]
        [Display(Name = "���z����")]
        public decimal? HaibunJoken { get; set; }

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