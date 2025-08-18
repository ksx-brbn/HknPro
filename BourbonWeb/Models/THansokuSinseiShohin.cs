using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\�����i����")]
    public class THansokuSinseiShohin
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

        [Column("SINSEI_NO")]
        [Display(Name = "�\���ԍ�")]
        public string? SinseiNo { get; set; }

        [Column("SINSEI_GYO_NO")]
        [Display(Name = "�\���s�ԍ�")]
        public short? SinseiGyoNo { get; set; }

        [Column("SINSEI_MEISAI_CD_KBN")]
        [Display(Name = "���׃R�[�h�敪")]
        public string? SinseiMeisaiCdKbn { get; set; }

        [Column("SINSEI_SHOHIN_CD_KBN")]
        [Display(Name = "���i�R�[�h�g�p�敪")]
        public string? SinseiShohinCdKbn { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "�c�ƕ���")]
        public string? EigyoBunrui { get; set; }

        [Column("SINSEI_MEISAI_CD")]
        [Display(Name = "���׃R�[�h")]
        public string? SinseiMeisaiCd { get; set; }

        [Column("SINSEI_NAIYO")]
        [Display(Name = "�\�����e")]
        public string? SinseiNaiyo { get; set; }

        [Column("JISHA_TAISHO_KINGAKU")]
        [Display(Name = "���БΏۋ��z")]
        public decimal? JishaTaishoKingaku { get; set; }

        [Column("TATENE")]
        [Display(Name = "���l")]
        public decimal? Tatene { get; set; }

        [Column("TORIHIKI_TAISHO_KINGAKU")]
        [Display(Name = "�����Ώۋ��z")]
        public decimal? TorihikiTaishoKingaku { get; set; }

        [Column("NOKA")]
        [Display(Name = "�[��")]
        public decimal? Noka { get; set; }

        [Column("TONYA_HAKIDASI_REBATE_RITU")]
        [Display(Name = "�≮�f�o���x�[�g��")]
        public decimal? TonyaHakidasiRebateRitu { get; set; }

        [Column("TONYA_HAKIDASI_GAKU")]
        [Display(Name = "�≮�f�o�z(1��)")]
        public decimal? TonyaHakidasiGaku { get; set; }

        [Column("TONYA_TAISHO_GAKU")]
        [Display(Name = "�≮�Ώۊz")]
        public decimal? TonyaTaishoGaku { get; set; }

        [Column("KYOSAN_JOKEN")]
        [Display(Name = "���^����")]
        public decimal? KyosanJoken { get; set; }

        [Column("KYOSAN_SURYO_A")]
        [Display(Name = "���^���`")]
        public int? KyosanSuryoA { get; set; }

        [Column("KYOSAN_SURYO_B")]
        [Display(Name = "���^���a")]
        public int? KyosanSuryoB { get; set; }

        [Column("KYOSAN_SURYO_C")]
        [Display(Name = "���^���b")]
        public int? KyosanSuryoC { get; set; }

        [Column("KYOSAN_SOBARASU")]
        [Display(Name = "���^���o����")]
        public int? KyosanSobirasu { get; set; }

        [Column("KYOSAN_GAKU")]
        [Display(Name = "���^�z")]
        public decimal? KyosanGaku { get; set; }

        [Column("KYOSAN_GAKU_ZEI_KBN")]
        [Display(Name = "���^�z����ŋ敪")]
        public string? KyosanGakuZeiKbn { get; set; }

        [Column("KYOSAN_GAKU_ZEI_RITU")]
        [Display(Name = "���^�z����ŗ�")]
        public decimal? KyosanGakuZeiRitu { get; set; }

        [Column("KYOSAN_GAKU_ZEI_GAKU")]
        [Display(Name = "���^�z����Ŋz")]
        public decimal? KyosanGakuZeiGaku { get; set; }

        [Column("HIMOKU_KYOSAN_GAKU_CHOSEI")]
        [Display(Name = "��ڕʋ��^�z�����z")]
        public decimal? HimokuKyosanGakuChosei { get; set; }

        [Column("KYOSAN_NAIYO_COMMENT")]
        [Display(Name = "���^���e�R�����g����")]
        public string? KyosanNaiyoComment { get; set; }

        [Column("TORIKOMI_KBN")]
        [Display(Name = "�捞�敪")]
        public string? TorikomiKbn { get; set; }

        [Column("TORIHIKI_SHOHIN_CD_SIYO_KBN")]
        [Display(Name = "����揤�i�R�[�h�g�p�敪")]
        public string? TorihikiShohinCdSiyoKbn { get; set; }

        [Column("TORIHIKI_SHOHIN_CD")]
        [Display(Name = "����揤�i�R�[�h")]
        public string? TorihikiShohinCd { get; set; }

        [Column("TORIHIKI_SENYO_SHOHIN_CD")]
        [Display(Name = "������p���i�R�[�h")]
        public string? TorihikiSenyoShohinCd { get; set; }

        [Column("TORIHIKI_SITEI_TANKA")]
        [Display(Name = "�����w��P��")]
        public decimal? TorihikiSiteiTanka { get; set; }

        [Column("TORIHIKI_JOKEN_KBN")]
        [Display(Name = "���������敪")]
        public string? TorihikiJokenKbn { get; set; }

        [Column("TORIHIKI_JOKEN")]
        [Display(Name = "��������")]
        public decimal? TorihikiJoken { get; set; }

        [Column("TORIHIKI_SEIKYU_TAISHO_TANI_KBN")]
        [Display(Name = "����搿���Ώې��ʁ^���z�P��")]
        public string? TorihikiSeikyuTaishoTaniKbn { get; set; }

        [Column("TORIHIKI_SEIKYU_KEIJO_TAISHO_GAKU_SURYO")]
        [Display(Name = "����搿���v��Ώې��ʁ^���z")]
        public decimal? TorihikiSeikyuKeijoTaishoGakuSuryo { get; set; }

        [Column("TORIHIKI_MISHU_NO")]
        [Display(Name = "����斢���ԍ�")]
        public string? TorihikiMishuNo { get; set; }

        [Column("TORIHIKI_SEIKYU_SIME")]
        [Display(Name = "����搿������")]
        public string? TorihikiSeikyuSime { get; set; }

        [Column("DENPYO_NITIJI")]
        [Display(Name = "�`�[����")]
        public string? DenpyoNitiji { get; set; }

        [Column("DENPYO_NO")]
        [Display(Name = "�`�[�ԍ�")]
        public string? DenpyoNo { get; set; }

        [Column("DENPYO_GYO_NO")]
        [Display(Name = "�`�[�s�ԍ�")]
        public short? DenpyoGyoNo { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "������R�[�h")]
        public string? SeikyuCd { get; set; }

        [Column("SEIKYU_GAITO_YMD")]
        [Display(Name = "�����Y����")]
        public string? SeikyuGaitoYmd { get; set; }

        [Column("DENPYO_YMD")]
        [Display(Name = "�`�[�N����")]
        public string? DenpyoYmd { get; set; }

        [Column("TANTO_SHO")]
        [Display(Name = "�S����")]
        public string? TantoSho { get; set; }

        [Column("SAGAKU_REC_KBN")]
        [Display(Name = "���z���R�[�h�敪")]
        public string? SagakuRecKbn { get; set; }

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "�̑���ڃR�[�h")]
        public string? HansokHimokuCd { get; set; }

        [Column("MITUMORI_TEKIYO")]
        [Display(Name = "���ϓK�p")]
        public string? MitumoriTekiyo { get; set; }

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

        [Column("MITUMORI_TEKIYO_NO")]
        [Display(Name = "���ϓK�p�ԍ�")]
        public string? MitumoriTekiyoNo { get; set; }

        [Column("URIAGE_KOUJYO_HANTEI")]
        [Display(Name = "����T������")]
        public string? UriageKoujyoHantei { get; set; }

        [Column("HANSOKU_NAIYOU")]
        [Display(Name = "�̑����e")]
        public string? HansokuNaiyou { get; set; }

        [Column("ZEI_RITU_KBN")]
        [Display(Name = "�ŗ��敪")]
        public string? ZeiRituKbn { get; set; }

        [Column("ITTAI_SISAN_KBN")]
        [Display(Name = "��ю��Y�敪")]
        public string? IttaiSisanKbn { get; set; }

        [Column("KEIHI_BUNRUI")]
        [Display(Name = "�o���")]
        public string? KeihiBunrui { get; set; }
    }
}