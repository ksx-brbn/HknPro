using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���i�̑��}�X�^")]
    public class MKhJoken
    {
        [Column("KAKAKU_HANSOKU_NO")]
        [Display(Name = "���i�̑��ԍ�")]
        public string? KakakuHansokuNo { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "�ΏۊJ�n��")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "�ΏۏI����")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("KAKAKU_HANSOKU_MAIN_NM")]
        [Display(Name = "���i�̑����")]
        public string? KakakuHansokuMainNm { get; set; }

        [Column("KAKAKU_HANSOKU_SUB_NM")]
        [Display(Name = "���i�̑�����")]
        public string? KakakuHansokuSubNm { get; set; }

        [Column("KIKAKU_ORDER_NO")]
        [Display(Name = "�\����")]
        public int? KikakuOrderNo { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_KBN_NM")]
        [Display(Name = "�����敪��")]
        public string? SeikyuKbnNm { get; set; }

        [Column("SHUKKA_KEITAI")]
        [Display(Name = "�o�׌`��")]
        public string? ShukkaKeitai { get; set; }

        [Column("SHUKKA_KEITAI_NM")]
        [Display(Name = "�o�׌`�Ԗ�")]
        public string? ShukkaKeitaiNm { get; set; }

        [Column("SINSEI_HOHO")]
        [Display(Name = "�\�����@")]
        public string? SinseiHoho { get; set; }

        [Column("SINSEI_HOHO_NM")]
        [Display(Name = "�\�����@��")]
        public string? SinseiHohoNm { get; set; }

        [Column("TEKIYO_AREA_KBN")]
        [Display(Name = "�K�p�G���A�敪")]
        public string? TekiyoAreaKbn { get; set; }

        [Column("TEKIYO_AREA_KBN_NM")]
        [Display(Name = "�K�p�G���A��")]
        public string? TekiyoAreaKbnNm { get; set; }

        [Column("TEKIYO_AREA_SHOSAI_CD")]
        [Display(Name = "�K�p�G���A�ڍ�CD")]
        public string? TekiyoAreaShosaiCd { get; set; }

        [Column("TEKIYO_AREA_SHOSAI_NM")]
        [Display(Name = "�K�p�G���A�ڍז�")]
        public string? TekiyoAreaShosaiNm { get; set; }

        [Column("TEKIYO_JOKEN_KBN")]
        [Display(Name = "�K�p�����敪")]
        public string? TekiyoJokenKbn { get; set; }

        [Column("TEKIYO_JOKEN_KBN_NM")]
        [Display(Name = "�K�p������")]
        public string? TekiyoJokenKbnNm { get; set; }

        [Column("KAKAKU_HANSOKU_COMMENT")]
        [Display(Name = "���i�̑��R�����g")]
        public string? KakakuHansokuComment { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("KOUKAI_KBN")]
        [Display(Name = "���J�敪")]
        public string? KoukaiKbn { get; set; }

        [Column("KOUKAI_KBN_NM")]
        [Display(Name = "���J�敪��")]
        public string? KoukaiKbnNm { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "�o�^��")]
        public DateTime? CreatedAt { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "�o�^��")]
        public string? CreatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "�X�V��")]
        public DateTime? UpdatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "�X�V��")]
        public string? UpdatedId { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "�폜�t���O")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "���b�N�o�[�W����")]
        public int? LockVersion { get; set; }

    }
}