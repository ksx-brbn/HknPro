using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���i�̑��ʃ}�X�^")]
    public class MKakakuHansokuKobetu
    {
        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KaisiYmd { get; set; }

        [Column("SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? ShuryoYmd { get; set; }

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

        [Column("SHO_CD")]
        [Display(Name = "��CD")]
        public string? ShoCd { get; set; }

        [Column("TOKUI_CD")]
        [Display(Name = "���Ӑ�CD")]
        public string? TokuiCd { get; set; }

        [Column("KOBETU_CD")]
        [Display(Name = "��CD")]
        public string? KobetuCd { get; set; }

        [Column("KOBETU_NM")]
        [Display(Name = "�ʖ�")]
        public string? KobetuNm { get; set; }

        [Column("MISE_JOKEN")]
        [Display(Name = "�X����")]
        public string? MiseJoken { get; set; }

        [Column("JOKEN_KBN")]
        [Display(Name = "�����敪")]
        public string? JokenKbn { get; set; }

        [Column("JOKEN")]
        [Display(Name = "����")]
        public decimal? Joken { get; set; }

        [Column("URIAGE_SHOMEI")]
        [Display(Name = "����ؖ�")]
        public string? UriageShomei { get; set; }

        [Column("BIKO")]
        [Display(Name = "���l")]
        public string? Biko { get; set; }

        [Column("KOKAI_YMD")]
        [Display(Name = "���J�N����")]
        public string? KokaiYmd { get; set; }

        [Column("TOROKU_YMD")]
        [Display(Name = "�o�^�N����")]
        public string? TorokuYmd { get; set; }

        [Column("KOSIN_YMD")]
        [Display(Name = "�X�V�N����")]
        public string? KosinYmd { get; set; }

        [Column("DELETE_FLG")]
        [Display(Name = "�폜�t���O")]
        public string? DeleteFlg { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "����T������")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "�ŗ��敪")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "��ю��Y�敪")]
        public string? IttaiSisanKbn { get; set; }

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "�̑����CD")]
        public string? HansokHimokuCd { get; set; }

    }
}