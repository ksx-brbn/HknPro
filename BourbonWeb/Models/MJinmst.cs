using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�Ј��}�X�^")]
    public class MJinmst
    {
        [Column("KEY_SHAIN_NO")]
        [Display(Name = "�Ј�No")]
        public string? KeyShainNo { get; set; }

        [Column("KEY_KAISI_YMD")]
        [Display(Name = "�J�n�N����")]
        public string? KeyKaisiYmd { get; set; }

        [Column("SHURYO_YMD")]
        [Display(Name = "�I���N����")]
        public string? ShuryoYmd { get; set; }

        [Column("SHAIN_NAME")]
        [Display(Name = "�Ј���")]
        public string? ShainName { get; set; }

        [Column("SHAIN_KANA")]
        [Display(Name = "�Ј����J�i")]
        public string? ShainKana { get; set; }

        [Column("SEIBETU")]
        [Display(Name = "����")]
        public string? Seibetu { get; set; }

        [Column("SAIYOU_KBN")]
        [Display(Name = "�̗p�敪")]
        public string? SaiyouKbn { get; set; }

        [Column("KOYOU_KBN")]
        [Display(Name = "�ٗp�敪")]
        public string? KoyouKbn { get; set; }

        [Column("GAKUSOTU_YMD")]
        [Display(Name = "�w���N����")]
        public string? GakusotuYmd { get; set; }

        [Column("NYUSHA_YMD")]
        [Display(Name = "���ДN����")]
        public string? NyushaYmd { get; set; }

        [Column("HONKOYO_YMD")]
        [Display(Name = "�{�ٗp�N����")]
        public string? HonkoyoYmd { get; set; }

        [Column("TAISHOKU_FLG")]
        [Display(Name = "�ސE�t���O")]
        public string? TaishokuFlg { get; set; }

        [Column("TAISHOKU_YMD")]
        [Display(Name = "�ސE�N����")]
        public string? TaishokuYmd { get; set; }

        [Column("TAISHOKU_RIYU")]
        [Display(Name = "�ސE���R")]
        public string? TaishokuRiyu { get; set; }

        [Column("SEINEN_YMD")]
        [Display(Name = "���N����")]
        public string? SeinenYmd { get; set; }

        [Column("TENKYO_YMD")]
        [Display(Name = "�]���N����")]
        public string? TenkyoYmd { get; set; }

        [Column("TEL1_NO")]
        [Display(Name = "�d�b�ԍ�1")]
        public string? Tel1No { get; set; }

        [Column("KEITAI1_NO")]
        [Display(Name = "�g�єԍ�1")]
        public string? Keitai1No { get; set; }

        [Column("KEITAI2_NO")]
        [Display(Name = "�g�єԍ�2")]
        public string? Keitai2No { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "FAX")]
        public string? FaxNo { get; set; }

        [Column("TEL2_NO")]
        [Display(Name = "�d�b�ԍ�2")]
        public string? Tel2No { get; set; }

        [Column("SHOZOKU_CD")]
        [Display(Name = "����CD")]
        public string? ShozokuCd { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("YAKSHOK_CD")]
        [Display(Name = "��ECD")]
        public string? YakshokCd { get; set; }

        [Column("HIMOKU_CD")]
        [Display(Name = "���CD")]
        public string? HimokuCd { get; set; }

        [Column("SHOKSHO_CD")]
        [Display(Name = "�E��CD")]
        public string? ShokshoCd { get; set; }

        [Column("SHOKSHU_CD")]
        [Display(Name = "�E��CD")]
        public string? ShokshuCd { get; set; }

        [Column("SHAINKBN_CD")]
        [Display(Name = "�Ј��敪")]
        public string? ShainkbnCd { get; set; }

        [Column("KEIYAKU_NISU")]
        [Display(Name = "�_�����")]
        public int? KeiyakuNisu { get; set; }

        [Column("KEIYAKU_JIKAN")]
        [Display(Name = "�_�񎞊�")]
        public int? KeiyakuJikan { get; set; }

        [Column("RENKEI_YMD")]
        [Display(Name = "�A�g�N����")]
        public string? RenkeiYmd { get; set; }

    }
}