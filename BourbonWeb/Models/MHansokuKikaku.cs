using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑����}�X�^")]
    public class MHansokuKikaku
    {
        [Column("HANSOK_KIKAKU_CD")]
        [Display(Name = "�̑����CD")]
        public string? HansokKikakuCd { get; set; }

        [Column("HANSOK_KIKAKU_NM")]
        [Display(Name = "�̑���於")]
        public string? HansokKikakuNm { get; set; }

        [Column("SEIKYU_CHOAI_CD")]
        [Display(Name = "�Ώۊ��CD")]
        public string? SeikyuChoaiCd { get; set; }

        [Column("SEIKYU_CHOAI_NM")]
        [Display(Name = "�Ώۊ�Ɩ�")]
        public string? SeikyuChoaiNm { get; set; }

        [Column("TAISHO_MISE_CD")]
        [Display(Name = "�ΏۓXCD")]
        public string? TaishoMiseCd { get; set; }

        [Column("TAISHO_MISE_NM")]
        [Display(Name = "�ΏۓX��")]
        public string? TaishoMiseNm { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("TAISHO_KAISI_YMD")]
        [Display(Name = "�ΏۊJ�n�N����")]
        public string? TaishoKaisiYmd { get; set; }

        [Column("TAISHO_SHURYO_YMD")]
        [Display(Name = "�ΏۏI���N����")]
        public string? TaishoShuryoYmd { get; set; }

        [Column("TAISHO_MISE_OYA_CD")]
        [Display(Name = "�ΏۓX�eCD")]
        public string? TaishoMiseOyaCd { get; set; }

        [Column("JOKEN_TEKIYO_KBN")]
        [Display(Name = "�����E�v�敪")]
        public string? JokenTekiyoKbn { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_KBN_NM")]
        [Display(Name = "�����敪��")]
        public string? SeikyuKbnNm { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "���^����")]
        public string? KyosanJoken { get; set; }

        [Column("KYOSAN_JOKEN_NM")]
        [Display(Name = "���^������")]
        public string? KyosanJokenNm { get; set; }

        [Column("JOTAI_KBN")]
        [Display(Name = "��ԋ敪")]
        public short? JotaiKbn { get; set; }

        [Column("SHUKKA_KEITAI")]
        [Display(Name = "�o�׌`��")]
        public string? ShukkaKeitai { get; set; }

        [Column("TANTO_BUMON_CD")]
        [Display(Name = "�S������CD")]
        public string? TantoBumonCd { get; set; }

        [Column("TANTO_BUMON_NM")]
        [Display(Name = "�S�����喼")]
        public string? TantoBumonNm { get; set; }

        [Column("TANTO_KA_NM")]
        [Display(Name = "�S���ۖ�")]
        public string? TantoKaNm { get; set; }

        [Column("TANTO_SHO_CD")]
        [Display(Name = "�S����CD")]
        public string? TantoShoCd { get; set; }

        [Column("TANTO_SHO_NM")]
        [Display(Name = "�S������")]
        public string? TantoShoNm { get; set; }

        [Column("TANTO_SHA_CD")]
        [Display(Name = "�S����CD")]
        public string? TantoShaCd { get; set; }

        [Column("TANTO_SHA_NM")]
        [Display(Name = "�S���Җ�")]
        public string? TantoShaNm { get; set; }

        [Column("MITUMORI_TEKIYO_JOKEN")]
        [Display(Name = "���ϓK�p����")]
        public string? MitumoriTekiyoJoken { get; set; }

        [Column("MITUMORI_NYURYOKU_HOHO")]
        [Display(Name = "���ϓ��͕��@")]
        public string? MitumoriNyuryokuHoho { get; set; }

        [Column("SHONIN_SHA_CD_1")]
        [Display(Name = "�ꎟ���F��CD")]
        public string? ShoninShaCd1 { get; set; }

        [Column("SHONIN_SHA_NM_1")]
        [Display(Name = "�ꎟ���F�Җ�")]
        public string? ShoninShaNm1 { get; set; }

        [Column("SHONIN_YMD_1")]
        [Display(Name = "�ꎟ���F��")]
        public string? ShoninYmd1 { get; set; }

        [Column("SHONIN_HMS_1")]
        [Display(Name = "�ꎟ���F����")]
        public string? ShoninHms1 { get; set; }

        [Column("SHONIN_SHA_CD_2")]
        [Display(Name = "�񎟏��F��CD")]
        public string? ShoninShaCd2 { get; set; }

        [Column("SHONIN_SHA_NM_2")]
        [Display(Name = "�񎟏��F�Җ�")]
        public string? ShoninShaNm2 { get; set; }

        [Column("SHONIN_YMD_2")]
        [Display(Name = "�񎟏��F��")]
        public string? ShoninYmd2 { get; set; }

        [Column("SHONIN_HMS_2")]
        [Display(Name = "�񎟏��F����")]
        public string? ShoninHms2 { get; set; }

        [Column("SHONIN_SHA_CD_3")]
        [Display(Name = "�O�����F��CD")]
        public string? ShoninShaCd3 { get; set; }

        [Column("SHONIN_SHA_NM_3")]
        [Display(Name = "�O�����F�Җ�")]
        public string? ShoninShaNm3 { get; set; }

        [Column("SHONIN_YMD_3")]
        [Display(Name = "�O�����F��")]
        public string? ShoninYmd3 { get; set; }

        [Column("SHONIN_HMS_3")]
        [Display(Name = "�O�����F����")]
        public string? ShoninHms3 { get; set; }

        [Column("LATEST_SHONIN_JOTAI")]
        [Display(Name = "���ߏ��F���")]
        public short? LatestShoninJotai { get; set; }

        [Column("LATEST_SHONIN_SHA_CD")]
        [Display(Name = "���ߏ��F��CD")]
        public string? LatestShoninShaCd { get; set; }

        [Column("LATEST_SHONIN_SHA_NM")]
        [Display(Name = "���ߏ��F�Җ�")]
        public string? LatestShoninShaNm { get; set; }

        [Column("LATEST_SHONIN_YMD")]
        [Display(Name = "���ߏ��F��")]
        public string? LatestShoninYmd { get; set; }

        [Column("LATEST_SHONIN_HMS")]
        [Display(Name = "���ߏ��F����")]
        public string? LatestShoninHms { get; set; }

        [Column("SHONIN_IRAI_TUTI_FLG")]
        [Display(Name = "���F�˗��ʒm�t���O")]
        public string? ShoninIraiTutiFlg { get; set; }

        [Column("SHONIN_IRAI_TUTI_CNT")]
        [Display(Name = "���F�˗��ʒm��")]
        public short? ShoninIraiTutiCnt { get; set; }

        [Column("SHONIN_IRAI_TUTI_NITIJI")]
        [Display(Name = "���F�˗��ʒm����")]
        public string? ShoninIraiTutiNitiji { get; set; }

        [Column("PRINT_CNT")]
        [Display(Name = "�����")]
        public int? PrintCnt { get; set; }

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

        [Column("CD_KBN")]
        [Display(Name = "CD�敪")]
        public string? CdKbn { get; set; }

        [Column("URI_KBN")]
        [Display(Name = "���敪")]
        public string? UriKbn { get; set; }

        [Column("TEISYUTU_SAKI")]
        [Display(Name = "��o��")]
        public string? TeisyutuSaki { get; set; }

        [Column("NEBIKI_SYUBETU")]
        [Display(Name = "�l�������")]
        public string? NebikiSyubetu { get; set; }

        [Column("MITUMORI_TEKIYO_KIKAN")]
        [Display(Name = "���ϓK�p����")]
        public string? MitumoriTekiyoKikan { get; set; }

        [Column("MITUMORI_KEIZOKU_FLG")]
        [Display(Name = "���όp���t���O")]
        public string? MitumoriKeizokuFlg { get; set; }

        [Column("HANSOKU_KIKAKU_CD_BASE")]
        [Display(Name = "�̑����CD��")]
        public string? HansokuKikakuCdBase { get; set; }
    }
}