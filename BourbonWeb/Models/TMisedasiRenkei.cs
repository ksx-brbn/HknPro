using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�X�o�A�g���")]
    public class TMisedasiRenkei
    {
        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("SOSIN_MOTO_CD")]
        [Display(Name = "���M���R�[�h")]
        public string? SosinMotoCd { get; set; }

        [Column("SOSIN_MOTO_NM")]
        [Display(Name = "���M����Ɩ�")]
        public string? SosinMotoNm { get; set; }

        [Column("ICHIJITEN_CD")]
        [Display(Name = "�ꎟ�X�R�[�h")]
        public string? IchijitenCd { get; set; }

        [Column("ICHIJITEN_NM")]
        [Display(Name = "�ꎟ�X��")]
        public string? IchijitenNm { get; set; }

        [Column("NIJITEN_CD")]
        [Display(Name = "�񎟓X�R�[�h")]
        public string? NijitenCd { get; set; }

        [Column("NIJITEN_NM")]
        [Display(Name = "�񎟓X��")]
        public string? NijitenNm { get; set; }

        [Column("TODOKESAKI_CD")]
        [Display(Name = "�͐�R�[�h")]
        public string? TodokesakiCd { get; set; }

        [Column("TODOKESAKI_NM")]
        [Display(Name = "�͐於")]
        public string? TodokesakiNm { get; set; }

        [Column("TODOKESAKI_GROUP_CD")]
        [Display(Name = "�͐�O���[�v�R�[�h")]
        public string? TodokesakiGroupCd { get; set; }

        [Column("TODOKESAKI_GROUP_NM")]
        [Display(Name = "�͐�O���[�v��")]
        public string? TodokesakiGroupNm { get; set; }

        [Column("BOURBON_HONTEN_CD")]
        [Display(Name = "�u���{���{�X�R�[�h")]
        public string? BourbonHontenCd { get; set; }

        [Column("BOURBON_ICHIJITEN_CD")]
        [Display(Name = "�u���{���ꎟ�X�R�[�h")]
        public string? BourbonIchijitenCd { get; set; }

        [Column("BOURBON_NIJITEN_CD")]
        [Display(Name = "�u���{���񎟓X�R�[�h")]
        public string? BourbonNijitenCd { get; set; }

        [Column("BOURBON_TODOKESAKI_CD")]
        [Display(Name = "�u���{���͐�R�[�h")]
        public string? BourbonTodokesakiCd { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "�Ώۊ��Ԏ�")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "�Ώۊ��Ԏ�")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("BOURBON_SHOHIN_CD")]
        [Display(Name = "�u���{�����i�R�[�h")]
        public string? BourbonShohinCd { get; set; }

        [Column("BOURBON_SHOHIN_CD_EDA")]
        [Display(Name = "�u���{�����i�R�[�h�}��")]
        public string? BourbonShohinCdEda { get; set; }

        [Column("BOURBON_SHOHIN_NM")]
        [Display(Name = "�u���{�����i��")]
        public string? BourbonShohinNm { get; set; }

        [Column("BARA_SOSU")]
        [Display(Name = "�o������")]
        public decimal? BaraSosu { get; set; }

        [Column("BOURBON_TATENE")]
        [Display(Name = "�u���{�����l")]
        public decimal? BourbonTatene { get; set; }

        [Column("TODOKE_HANBAI_TANKA")]
        [Display(Name = "�͐�̔��P��")]
        public decimal? TodokeHanbaiTanka { get; set; }

        [Column("HANBAI_GOKEI_GAKU")]
        [Display(Name = "�̔����v���z")]
        public decimal? HanbaiGokeiGaku { get; set; }

        [Column("TATENE_GOKEI_GAKU")]
        [Display(Name = "���l���v���z")]
        public decimal? TateneGokeiGaku { get; set; }

        [Column("MISEDASI_JUSIN_YMD")]
        [Display(Name = "�X�o��M��")]
        public string? MisedasiJusinYmd { get; set; }

        [Column("TORIKOMI_YMD")]
        [Display(Name = "�捞���t")]
        public string? TorikomiYmd { get; set; }

        [Column("TORIKOMI_SINSEI_NO")]
        [Display(Name = "�捞���")]
        public string? TorikomiSinseiNo { get; set; }
    }
}