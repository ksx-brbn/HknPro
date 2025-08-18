using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���U������")]
    public class THansokuFurikomi
    {
        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "�̑���\���Ӕԍ�")]
        public string? SinseiKagamiNo { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "���|����")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "������CD")]
        public string? SeikyuCd { get; set; }

        [Column("CHOAI_CD")]
        [Display(Name = "�����XCD")]
        public string? ChoaiCd { get; set; }

        [Column("TORIHIKI_CD")]
        [Display(Name = "���Ӑ�CD")]
        public string? TorihikiCd { get; set; }

        [Column("FURIKOMISAKI_CD")]
        [Display(Name = "�U����CD")]
        public string? FurikomisakiCd { get; set; }

        [Column("FURIKOMISAKI_NM")]
        [Display(Name = "�U���於")]
        public string? FurikomisakiNm { get; set; }

        [Column("GCD")]
        [Display(Name = "��sCD")]
        public string? Gcd { get; set; }

        [Column("GINKO_NMK")]
        [Display(Name = "��s����")]
        public string? GinkoNmk { get; set; }

        [Column("GINKO_NMN")]
        [Display(Name = "��s��")]
        public string? GinkoNmn { get; set; }

        [Column("SCD")]
        [Display(Name = "�x�XCD")]
        public string? Scd { get; set; }

        [Column("SITEN_NMK")]
        [Display(Name = "�x�X����")]
        public string? SitenNmk { get; set; }

        [Column("SITEN_NMN")]
        [Display(Name = "�x�X��")]
        public string? SitenNmn { get; set; }

        [Column("YOKIN_SHUMOKU")]
        [Display(Name = "�a�����")]
        public string? YokinShumoku { get; set; }

        [Column("KOZA_NO")]
        [Display(Name = "�����ԍ�")]
        public string? KozaNo { get; set; }

        [Column("KOZA_MEIGININ_NMK")]
        [Display(Name = "�������`�l��")]
        public string? KozaMeigininNmk { get; set; }

        [Column("KOZA_MEIGININ_NMN")]
        [Display(Name = "�������`�l")]
        public string? KozaMeigininNmn { get; set; }

        [Column("FURIKOMI_YMD")]
        [Display(Name = "�U����")]
        public string? FurikomiYmd { get; set; }

        [Column("SIHARAI_GAKU_ZEI_NUKI")]
        [Display(Name = "�x�����z�Ŕ�")]
        public decimal? SiharaiGakuZeiNuki { get; set; }

        [Column("SIHARAI_GAKU_ZEI_GAKU")]
        [Display(Name = "�x�����z�����")]
        public decimal? SiharaiGakuZeiGaku { get; set; }

        [Column("SIHARAI_GAKU_ZEI_KOMI")]
        [Display(Name = "�x�����z�ō�")]
        public decimal? SiharaiGakuZeiKomi { get; set; }

        [Column("ONLINE_KBN")]
        [Display(Name = "�I�����C���敪")]
        public string? OnlineKbn { get; set; }

        [Column("KIKAN_KBN")]
        [Display(Name = "�@�֋敪")]
        public string? KikanKbn { get; set; }

        [Column("FURIKOMI_ID")]
        [Display(Name = "�U��ID")]
        public string? FurikomiId { get; set; }

        [Column("TUCHI_UMU")]
        [Display(Name = "�ʒm�L��")]
        public string? TuchiUmu { get; set; }

        [Column("FURIKOMI_DATA_SOSIN_YMD")]
        [Display(Name = "�U���f�[�^���M��")]
        public string? FurikomiDataSosinYmd { get; set; }

        [Column("FURIKOMI_DATA_SOSIN_TIME")]
        [Display(Name = "�U���f�[�^���M����")]
        public string? FurikomiDataSosinTime { get; set; }

        [Column("KEKKA_KOSIN_FLG")]
        [Display(Name = "���ʍX�V�t���O")]
        public string? KekkaKosinFlg { get; set; }

        [Column("KEKKA_KOSIN_YMD")]
        [Display(Name = "���ʍX�V��")]
        public string? KekkaKosinYmd { get; set; }

        [Column("KEKKA_KOSIN_TIME")]
        [Display(Name = "���ʍX�V����")]
        public string? KekkaKosinTime { get; set; }

        [Column("SHUBETU_CD")]
        [Display(Name = "���CD")]
        public string? ShubetuCd { get; set; }

        [Column("CD_KBN")]
        [Display(Name = "�R�[�h�敪")]
        public string? CdKbn { get; set; }

        [Column("FURIKOMI_IRAI_CD")]
        [Display(Name = "�U���˗��lCD")]
        public string? FurikomiIraiCd { get; set; }

        [Column("FURIKOMI_IRAI_NM")]
        [Display(Name = "�U���˗��l��")]
        public string? FurikomiIraiNm { get; set; }

        [Column("TORIKUMI_YMD")]
        [Display(Name = "��g��")]
        public string? TorikumiYmd { get; set; }

        [Column("SIMUKE_GCD")]
        [Display(Name = "�d����s�ԍ�")]
        public string? SimukeGcd { get; set; }

        [Column("SIMUKE_GINKO_NMK")]
        [Display(Name = "�d����s��")]
        public string? SimukeGinkoNmk { get; set; }

        [Column("SIMUKE_SCD")]
        [Display(Name = "�d���x�X�ԍ�")]
        public string? SimukeScd { get; set; }

        [Column("SIMUKE_SITEN_NMK")]
        [Display(Name = "�d���x�X��")]
        public string? SimukeSitenNmk { get; set; }

        [Column("SINKI_CD")]
        [Display(Name = "�V�KCD")]
        public string? SinkiCd { get; set; }

        [Column("KOKYAKU_CD1")]
        [Display(Name = "�ڋqCD�P")]
        public string? KokyakuCd1 { get; set; }

        [Column("KOKYAKU_CD2")]
        [Display(Name = "�ڋqCD�Q")]
        public string? KokyakuCd2 { get; set; }

        [Column("FURIKOMI_SITEI_KBN")]
        [Display(Name = "�U���w��敪")]
        public string? FurikomiSiteiKbn { get; set; }

        [Column("SIKIBETU_NO")]
        [Display(Name = "���ʔԍ�")]
        public string? SikibetuNo { get; set; }

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