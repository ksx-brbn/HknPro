using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "”Ì‘£”ïUæî•ñ")]
    public class THansokuFurikomi
    {
        [Column("KAISHA_CD")]
        [Display(Name = "‰ïĞCD")]
        public string? KaishaCd { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "”Ì‘£”ï\¿ŠÓ”Ô†")]
        public string? SinseiKagamiNo { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "”„Š|•ª—Ş")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "¿‹‹æ•ª")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "¿‹æCD")]
        public string? SeikyuCd { get; set; }

        [Column("CHOAI_CD")]
        [Display(Name = "’ ‡“XCD")]
        public string? ChoaiCd { get; set; }

        [Column("TORIHIKI_CD")]
        [Display(Name = "“¾ˆÓæCD")]
        public string? TorihikiCd { get; set; }

        [Column("FURIKOMISAKI_CD")]
        [Display(Name = "UæCD")]
        public string? FurikomisakiCd { get; set; }

        [Column("FURIKOMISAKI_NM")]
        [Display(Name = "Uæ–¼")]
        public string? FurikomisakiNm { get; set; }

        [Column("GCD")]
        [Display(Name = "‹âsCD")]
        public string? Gcd { get; set; }

        [Column("GINKO_NMK")]
        [Display(Name = "‹âs–¼¶Å")]
        public string? GinkoNmk { get; set; }

        [Column("GINKO_NMN")]
        [Display(Name = "‹âs–¼")]
        public string? GinkoNmn { get; set; }

        [Column("SCD")]
        [Display(Name = "x“XCD")]
        public string? Scd { get; set; }

        [Column("SITEN_NMK")]
        [Display(Name = "x“X–¼¶Å")]
        public string? SitenNmk { get; set; }

        [Column("SITEN_NMN")]
        [Display(Name = "x“X–¼")]
        public string? SitenNmn { get; set; }

        [Column("YOKIN_SHUMOKU")]
        [Display(Name = "—a‹àí–Ú")]
        public string? YokinShumoku { get; set; }

        [Column("KOZA_NO")]
        [Display(Name = "ŒûÀ”Ô†")]
        public string? KozaNo { get; set; }

        [Column("KOZA_MEIGININ_NMK")]
        [Display(Name = "ŒûÀ–¼‹`l¶Å")]
        public string? KozaMeigininNmk { get; set; }

        [Column("KOZA_MEIGININ_NMN")]
        [Display(Name = "ŒûÀ–¼‹`l")]
        public string? KozaMeigininNmn { get; set; }

        [Column("FURIKOMI_YMD")]
        [Display(Name = "U“ú")]
        public string? FurikomiYmd { get; set; }

        [Column("SIHARAI_GAKU_ZEI_NUKI")]
        [Display(Name = "x•¥‹àŠzÅ”²")]
        public decimal? SiharaiGakuZeiNuki { get; set; }

        [Column("SIHARAI_GAKU_ZEI_GAKU")]
        [Display(Name = "x•¥‹àŠzÁ”ïÅ")]
        public decimal? SiharaiGakuZeiGaku { get; set; }

        [Column("SIHARAI_GAKU_ZEI_KOMI")]
        [Display(Name = "x•¥‹àŠzÅ")]
        public decimal? SiharaiGakuZeiKomi { get; set; }

        [Column("ONLINE_KBN")]
        [Display(Name = "ƒIƒ“ƒ‰ƒCƒ“‹æ•ª")]
        public string? OnlineKbn { get; set; }

        [Column("KIKAN_KBN")]
        [Display(Name = "‹@ŠÖ‹æ•ª")]
        public string? KikanKbn { get; set; }

        [Column("FURIKOMI_ID")]
        [Display(Name = "UID")]
        public string? FurikomiId { get; set; }

        [Column("TUCHI_UMU")]
        [Display(Name = "’Ê’m—L–³")]
        public string? TuchiUmu { get; set; }

        [Column("FURIKOMI_DATA_SOSIN_YMD")]
        [Display(Name = "Uƒf[ƒ^‘—M“ú")]
        public string? FurikomiDataSosinYmd { get; set; }

        [Column("FURIKOMI_DATA_SOSIN_TIME")]
        [Display(Name = "Uƒf[ƒ^‘—MŠÔ")]
        public string? FurikomiDataSosinTime { get; set; }

        [Column("KEKKA_KOSIN_FLG")]
        [Display(Name = "Œ‹‰ÊXVƒtƒ‰ƒO")]
        public string? KekkaKosinFlg { get; set; }

        [Column("KEKKA_KOSIN_YMD")]
        [Display(Name = "Œ‹‰ÊXV“ú")]
        public string? KekkaKosinYmd { get; set; }

        [Column("KEKKA_KOSIN_TIME")]
        [Display(Name = "Œ‹‰ÊXVŠÔ")]
        public string? KekkaKosinTime { get; set; }

        [Column("SHUBETU_CD")]
        [Display(Name = "í•ÊCD")]
        public string? ShubetuCd { get; set; }

        [Column("CD_KBN")]
        [Display(Name = "ƒR[ƒh‹æ•ª")]
        public string? CdKbn { get; set; }

        [Column("FURIKOMI_IRAI_CD")]
        [Display(Name = "UˆË—ŠlCD")]
        public string? FurikomiIraiCd { get; set; }

        [Column("FURIKOMI_IRAI_NM")]
        [Display(Name = "UˆË—Šl–¼")]
        public string? FurikomiIraiNm { get; set; }

        [Column("TORIKUMI_YMD")]
        [Display(Name = "æ‘g“ú")]
        public string? TorikumiYmd { get; set; }

        [Column("SIMUKE_GCD")]
        [Display(Name = "dŒü‹âs”Ô†")]
        public string? SimukeGcd { get; set; }

        [Column("SIMUKE_GINKO_NMK")]
        [Display(Name = "dŒü‹âs–¼")]
        public string? SimukeGinkoNmk { get; set; }

        [Column("SIMUKE_SCD")]
        [Display(Name = "dŒüx“X”Ô†")]
        public string? SimukeScd { get; set; }

        [Column("SIMUKE_SITEN_NMK")]
        [Display(Name = "dŒüx“X–¼")]
        public string? SimukeSitenNmk { get; set; }

        [Column("SINKI_CD")]
        [Display(Name = "V‹KCD")]
        public string? SinkiCd { get; set; }

        [Column("KOKYAKU_CD1")]
        [Display(Name = "ŒÚ‹qCD‚P")]
        public string? KokyakuCd1 { get; set; }

        [Column("KOKYAKU_CD2")]
        [Display(Name = "ŒÚ‹qCD‚Q")]
        public string? KokyakuCd2 { get; set; }

        [Column("FURIKOMI_SITEI_KBN")]
        [Display(Name = "Uw’è‹æ•ª")]
        public string? FurikomiSiteiKbn { get; set; }

        [Column("SIKIBETU_NO")]
        [Display(Name = "¯•Ê”Ô†")]
        public string? SikibetuNo { get; set; }

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

        [Column("DELETED_FLG")]
        [Display(Name = "íœƒtƒ‰ƒO")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ƒƒbƒNƒo[ƒWƒ‡ƒ“")]
        public int? LockVersion { get; set; }
    }
}