using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\���ӏ��")]
    public class THansokuSinseiKagami
    {
        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "���|����")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "�\�����ԍ�")]
        public string? SinseiKagamiNo { get; set; }

        [Column("KAIKEI_KEIJO_YM")]
        [Display(Name = "��v�v��N��")]
        public string? KaikeiKeijoYm { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_NO")]
        [Display(Name = "�\���ӑ�\�ԍ�")]
        public string? SinseiKagamiDaihyoNo { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_CD")]
        [Display(Name = "�\���ӑ�\�R�[�h")]
        public string? SinseiKagamiDaihyoCd { get; set; }

        [Column("SINSEI_KAGAMI_DAIHYO_NM")]
        [Display(Name = "�\���ӑ�\�X��")]
        public string? SinseiKagamiDaihyoNm { get; set; }

        [Column("SIHARAI_KEITAI")]
        [Display(Name = "�x���`��")]
        public string? SiharaiKeitai { get; set; }

        [Column("SIHARAI_SHUBETU")]
        [Display(Name = "�x�����")]
        public string? SiharaiShubetu { get; set; }

        [Column("SIHARAI_YOTEI_YMD")]
        [Display(Name = "�x���\���")]
        public string? SiharaiYoteiYmd { get; set; }

        [Column("SIHARAI_KAKUTEI_YMD")]
        [Display(Name = "�x���m���")]
        public string? SiharaiKakuteiYmd { get; set; }

        [Column("SIHARAI_KAKUTEI_NO")]
        [Display(Name = "�x���葱�m��ԍ�")]
        public string? SiharaiKakuteiNo { get; set; }

        [Column("SIHARAI_TETUZUKI_SHO_CD")]
        [Display(Name = "�x���葱���R�[�h")]
        public string? SiharaiTetuzukiShoCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHA_CD")]
        [Display(Name = "�x���葱�҃R�[�h")]
        public string? SiharaiTetuzukiShaCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHOZOKU_CD")]
        [Display(Name = "�x���葱�����R�[�h")]
        public string? SiharaiTetuzukiShozokuCd { get; set; }

        [Column("SIHARAI_TETUZUKI_SHOZOKU_NM")]
        [Display(Name = "�x���葱������")]
        public string? SiharaiTetuzukiShozokuNm { get; set; }

        [Column("SIHARAI_TETUZUKI_YMD")]
        [Display(Name = "�x���葱��")]
        public string? SiharaiTetuzukiYmd { get; set; }

        [Column("SIHARAI_TETUZUKI_TIME")]
        [Display(Name = "�x���葱����")]
        public string? SiharaiTetuzukiTime { get; set; }

        [Column("SHORI_YMD")]
        [Display(Name = "������")]
        public string? ShoriYmd { get; set; }

        [Column("SIWAKE_DENPYO_NO")]
        [Display(Name = "�d��`�[���͔ԍ�")]
        public string? SiwakeDenpyoNo { get; set; }

        [Column("SIWAKE_DENPYO_SUB_NO")]
        [Display(Name = "�d��`�[���͔ԍ��}��")]
        public string? SiwakeDenpyoSubNo { get; set; }

        [Column("KYOSAN_COMMENT_HYOSI")]
        [Display(Name = "���^���e�R�����g�\��")]
        public string? KyosanCommentHyosi { get; set; }

        [Column("JOTAI_KBN")]
        [Display(Name = "��ԋ敪")]
        public string? JotaiKbn { get; set; }

        [Column("SINSEI_KAGAMI_SHO_CD")]
        [Display(Name = "�Ӑ\�����R�[�h")]
        public string? SinseiKagamiShoCd { get; set; }

        [Column("SINSEI_KAGAMI_SHO_NM")]
        [Display(Name = "�Ӑ\������")]
        public string? SinseiKagamiShoNm { get; set; }

        [Column("SINSEI_KAGAMI_SHA_CD")]
        [Display(Name = "�Ӑ\���҃R�[�h")]
        public string? SinseiKagamiShaCd { get; set; }

        [Column("SINSEI_KAGAMI_SHA_NM")]
        [Display(Name = "�Ӑ\���Җ�")]
        public string? SinseiKagamiShaNm { get; set; }

        [Column("SINSEI_SHO_INSATU_YMD")]
        [Display(Name = "�\��������v����")]
        public string? SinseiShoInsatuYmd { get; set; }

        [Column("SINSEI_SHO_INSATU_TIME")]
        [Display(Name = "�\�����v������")]
        public string? SinseiShoInsatuTime { get; set; }

        [Column("SINSEI_SHO_INSATU_CNT")]
        [Display(Name = "�\�����v����")]
        public short? SinseiShoInsatuCnt { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "���^�z")]
        public decimal? KyosanGaku { get; set; }

        [Column("ZEI_KEISAN_KBN")]
        [Display(Name = "����Ōv�Z�敪")]
        public string? ZeiKeisanKbn { get; set; }

        [Column("ZEI_HASU_SHORI_KBN")]
        [Display(Name = "����Œ[�������敪")]
        public string? ZeiHasuShoriKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "���^�z����Ŋz")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU_CHOSEI")]
        [Display(Name = "���^�z����Œ����z")]
        public decimal? KyosanGakuZeiGakuChosei { get; set; }

        [Column("KYOSAN_GAKU_ZEI_NUKI")]
        [Display(Name = "���^�z�Ŕ��z")]
        public decimal? KyosanGakuZeiNuki { get; set; }

        [Column("DISPLAY_ORDER")]
        [Display(Name = "�\���\�[�g��")]
        public short? DisplayOrder { get; set; }

        [Column("URIKAKE_NEBIKI_RENKEI")]
        [Display(Name = "���|�l���A�g")]
        public string? UrikakeNebikiRenkei { get; set; }

        [Column("URIKAKE_SR_RENKEI")]
        [Display(Name = "���|SR�A�g")]
        public string? UrikakeSrRenkei { get; set; }

        [Column("EIGYO_AREA_RENKEI")]
        [Display(Name = "�c�ƃG���A�A�g")]
        public string? EigyoAreaRenkei { get; set; }

        [Column("SONOTA_RENKEI")]
        [Display(Name = "���̑��A�g")]
        public string? SonotaRenkei { get; set; }

        [Column("HONSHA_SHONIN_KAKUTEI_NO")]
        [Display(Name = "�{�Џ��F�m��ԍ�")]
        public string? HonshaShoninKakuteiNo { get; set; }

        [Column("HONSHA_SHONIN_SHO_CD")]
        [Display(Name = "�{�Џ��F�S�����R�[�h")]
        public string? HonshaShoninShoCd { get; set; }

        [Column("HONSHA_SHONIN_SHA_CD")]
        [Display(Name = "�{�Џ��F�S���҃R�[�h")]
        public string? HonshaShoninShaCd { get; set; }

        [Column("HONSHA_SHONIN_SHOZOKU_CD")]
        [Display(Name = "�{�Џ��F�����R�[�h")]
        public string? HonshaShoninShozokuCd { get; set; }

        [Column("HONSHA_SHONIN_SHOZOKU_NM")]
        [Display(Name = "�{�Џ��F������")]
        public string? HonshaShoninShozokuNm { get; set; }

        [Column("HONSHA_SHONIN_JOTAI_KBN")]
        [Display(Name = "�{�Џ��F��ԋ敪")]
        public string? HonshaShoninJotaiKbn { get; set; }

        [Column("HONSHA_SHONIN_YMD")]
        [Display(Name = "�{�Џ��F�N����")]
        public string? HonshaShoninYmd { get; set; }

        [Column("HONSHA_SHONIN_HMS")]
        [Display(Name = "�{�Џ��F����")]
        public string? HonshaShoninHms { get; set; }

        [Column("NYUKIN_RENKEI_SEIKYU_KBN")]
        [Display(Name = "�����A�g�����敪")]
        public string? NyukinRenkeiSeikyuKbn { get; set; }

        [Column("NYUKIN_RENKEI_SEIKYU_CD")]
        [Display(Name = "�����A�g�����R�[�h")]
        public string? NyukinRenkeiSeikyuCd { get; set; }

        [Column("NYUKIN_RENKEI_SIME_YMD")]
        [Display(Name = "�����A�g���N����")]
        public string? NyukinRenkeiSimeYmd { get; set; }

        [Column("TEISEI_DENPYO_KBN")]
        [Display(Name = "�����`�[�敪")]
        public string? TeiseiDenpyoKbn { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_SHA_CD")]
        [Display(Name = "�U�����׏o�͎�CD")]
        public string? FurikomiMeisaiPrintShaCd { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_YMD")]
        [Display(Name = "�U�����׏o�͔N����")]
        public string? FurikomiMeisaiPrintYmd { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_HMS")]
        [Display(Name = "�U�����׏o�͎���")]
        public string? FurikomiMeisaiPrintHms { get; set; }

        [Column("FURIKOMI_MEISAI_PRINT_COUNT")]
        [Display(Name = "�U�����׏o�͉�")]
        public int? FurikomiMeisaiPrintCount { get; set; }

        [Column("SIWAKE_RENKEI_KAKUTEI_NO")]
        [Display(Name = "�d��A�g��\�m��L��")]
        public string? SiwakeRenkeiKakuteiNo { get; set; }

        [Column("SIWAKE_RENKEI_KANRI_NO")]
        [Display(Name = "�d��A�g�Ǘ��ԍ�")]
        public int? SiwakeRenkeiKanriNo { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_SHA")]
        [Display(Name = "�d��A�g�f�[�^���M��")]
        public string? SiwakeRenkeiSosinSha { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_YMD")]
        [Display(Name = "�d��A�g�f�[�^���M��")]
        public string? SiwakeRenkeiSosinYmd { get; set; }

        [Column("SIWAKE_RENKEI_SOSIN_HMS")]
        [Display(Name = "�d��A�g�f�[�^���M����")]
        public string? SiwakeRenkeiSosinHms { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_SHA")]
        [Display(Name = "�d��A�g�f�[�^�m�F��")]
        public string? SiwakeRenkeiKakuninSha { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_YMD")]
        [Display(Name = "�d��A�g�f�[�^�m�F��")]
        public string? SiwakeRenkeiKakuninYmd { get; set; }

        [Column("SIWAKE_RENKEI_KAKUNIN_HMS")]
        [Display(Name = "�d��A�g�f�[�^�m�F����")]
        public string? SiwakeRenkeiKakuninHms { get; set; }

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