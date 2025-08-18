using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�X�o���M���}�X�^")]
    public class MMisedasiSosinmoto
    {
        [Column("TORIHIKI_KEIRO")]
        [Display(Name = "�����o�H")]
        public string? TorihikiKeiro { get; set; }

        [Column("SOSIN_MOTO_CD")]
        [Display(Name = "���M���R�[�h")]
        public string? SosinMotoCd { get; set; }

        [Column("BUNRUI_CD")]
        [Display(Name = "���ރR�[�h")]
        public string? BunruiCd { get; set; }

        [Column("SOSIN_MOTO_NM")]
        [Display(Name = "���M������")]
        public string? SosinMotoNm { get; set; }

        [Column("BOURBON_SOSIN_MOTO_NM")]
        [Display(Name = "�u���{���\���p���M������")]
        public string? BourbonSosinMotoNm { get; set; }

        [Column("BOURBON_HONTEN_CD")]
        [Display(Name = "�u���{���{�X�R�[�h")]
        public string? BourbonHontenCd { get; set; }

        [Column("BOURBON_TOKUI_CD")]
        [Display(Name = "�u���{�����Ӑ�R�[�h")]
        public string? BourbonTokuiCd { get; set; }

        [Column("BOURBON_TANTO_SHO_CD")]
        [Display(Name = "�u���{���S�����R�[�h")]
        public string? BourbonTantoShoCd { get; set; }

        [Column("JUSIN_CYCLE")]
        [Display(Name = "��M�T�C�N��")]
        public string? JusinCycle { get; set; }

        [Column("SAISIN_JUSINBI")]
        [Display(Name = "�ŐV��M��")]
        public string? SaisinJusinbi { get; set; }

        [Column("BIKO")]
        [Display(Name = "���l")]
        public string? Biko { get; set; }

        [Column("TOROKUBI")]
        [Display(Name = "�o�^��")]
        public string? Torokubi { get; set; }

        [Column("SORTKEY")]
        [Display(Name = "�\�[�g�敪")]
        public string? Sortkey { get; set; }

        [Column("HYOJI_KBN")]
        [Display(Name = "�\���敪")]
        public string? HyojiKbn { get; set; }

    }
}