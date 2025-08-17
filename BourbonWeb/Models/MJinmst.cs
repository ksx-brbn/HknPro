using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "社員マスタ")]
    public class MJinmst
    {
        [Column("KEY_SHAIN_NO")]
        [Display(Name = "社員No")]
        public string? KeyShainNo { get; set; }

        [Column("KEY_KAISI_YMD")]
        [Display(Name = "開始年月日")]
        public string? KeyKaisiYmd { get; set; }

        [Column("SHURYO_YMD")]
        [Display(Name = "終了年月日")]
        public string? ShuryoYmd { get; set; }

        [Column("SHAIN_NAME")]
        [Display(Name = "社員名")]
        public string? ShainName { get; set; }

        [Column("SHAIN_KANA")]
        [Display(Name = "社員名カナ")]
        public string? ShainKana { get; set; }

        [Column("SEIBETU")]
        [Display(Name = "性別")]
        public string? Seibetu { get; set; }

        [Column("SAIYOU_KBN")]
        [Display(Name = "採用区分")]
        public string? SaiyouKbn { get; set; }

        [Column("KOYOU_KBN")]
        [Display(Name = "雇用区分")]
        public string? KoyouKbn { get; set; }

        [Column("GAKUSOTU_YMD")]
        [Display(Name = "学卒年月日")]
        public string? GakusotuYmd { get; set; }

        [Column("NYUSHA_YMD")]
        [Display(Name = "入社年月日")]
        public string? NyushaYmd { get; set; }

        [Column("HONKOYO_YMD")]
        [Display(Name = "本雇用年月日")]
        public string? HonkoyoYmd { get; set; }

        [Column("TAISHOKU_FLG")]
        [Display(Name = "退職フラグ")]
        public string? TaishokuFlg { get; set; }

        [Column("TAISHOKU_YMD")]
        [Display(Name = "退職年月日")]
        public string? TaishokuYmd { get; set; }

        [Column("TAISHOKU_RIYU")]
        [Display(Name = "退職理由")]
        public string? TaishokuRiyu { get; set; }

        [Column("SEINEN_YMD")]
        [Display(Name = "生年月日")]
        public string? SeinenYmd { get; set; }

        [Column("TENKYO_YMD")]
        [Display(Name = "転居年月日")]
        public string? TenkyoYmd { get; set; }

        [Column("TEL1_NO")]
        [Display(Name = "電話番号1")]
        public string? Tel1No { get; set; }

        [Column("KEITAI1_NO")]
        [Display(Name = "携帯番号1")]
        public string? Keitai1No { get; set; }

        [Column("KEITAI2_NO")]
        [Display(Name = "携帯番号2")]
        public string? Keitai2No { get; set; }

        [Column("FAX_NO")]
        [Display(Name = "FAX")]
        public string? FaxNo { get; set; }

        [Column("TEL2_NO")]
        [Display(Name = "電話番号2")]
        public string? Tel2No { get; set; }

        [Column("SHOZOKU_CD")]
        [Display(Name = "所属CD")]
        public string? ShozokuCd { get; set; }

        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public string? KaishaCd { get; set; }

        [Column("YAKSHOK_CD")]
        [Display(Name = "役職CD")]
        public string? YakshokCd { get; set; }

        [Column("HIMOKU_CD")]
        [Display(Name = "費目CD")]
        public string? HimokuCd { get; set; }

        [Column("SHOKSHO_CD")]
        [Display(Name = "職所CD")]
        public string? ShokshoCd { get; set; }

        [Column("SHOKSHU_CD")]
        [Display(Name = "職種CD")]
        public string? ShokshuCd { get; set; }

        [Column("SHAINKBN_CD")]
        [Display(Name = "社員区分")]
        public string? ShainkbnCd { get; set; }

        [Column("KEIYAKU_NISU")]
        [Display(Name = "契約日数")]
        public int? KeiyakuNisu { get; set; }

        [Column("KEIYAKU_JIKAN")]
        [Display(Name = "契約時間")]
        public int? KeiyakuJikan { get; set; }

        [Column("RENKEI_YMD")]
        [Display(Name = "連携年月日")]
        public string? RenkeiYmd { get; set; }

    }
}