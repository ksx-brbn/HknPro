using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "”Ì‘£”ï\¿ŠÓ’²®î•ñ")]
    public class THansokuSinseiKagamiChosei
    {
        [Column("KAISHA_CD")]
        [Display(Name = "‰ïĞCD")]
        public string? KaishaCd { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "”„Š|•ª—Ş")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "¿‹‹æ•ª")]
        public string? SeikyuKbn { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "\¿ŠÓ”Ô†")]
        public string? SinseiKagamiNo { get; set; }

        [Column("ZEI_RITU")]
        [Display(Name = "Å—¦")]
        public decimal? ZeiRitu { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "Å—¦‹æ•ª")]
        public string? ZeiRituKbn { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "‹¦^Šz")]
        public decimal? KyosanGaku { get; set; }

        [Column("ZEI_GAKU")]
        [Display(Name = "ÅŠz")]
        public decimal? ZeiGaku { get; set; }

        [Column("ZEI_GAKU_CHOSEI")]
        [Display(Name = "ÅŠz’²®")]
        public decimal? ZeiGakuChosei { get; set; }

        [Column("REMARKS")]
        [Display(Name = "”õl")]
        public string? Remarks { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "“o˜^Ò")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "“o˜^“ú")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "XVÒ")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "XV“ú")]
        public DateTime? UpdatedAt { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ƒƒbƒNƒo[ƒWƒ‡ƒ“")]
        public int? LockVersion { get; set; }
    }
}