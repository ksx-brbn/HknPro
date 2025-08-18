using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���x�����m��\�����")]
    public class TMikakuteiSinsei
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

        [Column("SINSEI_TAISHO_YM")]
        [Display(Name = "�\���Ώ۔N��")]
        public string? SinseiTaishoYm { get; set; }

        [Column("SINSEI_KEIJO_YM")]
        [Display(Name = "�\���v��N��")]
        public string? SinseiKeijoYm { get; set; }

        [Column("SIHARAI_YOTEI_YMD")]
        [Display(Name = "�x���\��N����")]
        public string? SiharaiYoteiYmd { get; set; }

        [Column("KEIHI_SHO_CD")]
        [Display(Name = "�o�CD")]
        public string? KeihiShoCd { get; set; }

        [Column("KEIHI_SHO_NM")]
        [Display(Name = "�o���")]
        public string? KeihiShoNm { get; set; }

        [Column("KEIHI_SHA_CD")]
        [Display(Name = "�o���CD")]
        public string? KeihiShaCd { get; set; }

        [Column("KEIHI_SHA_NM")]
        [Display(Name = "�o��Җ�")]
        public string? KeihiShaNm { get; set; }

        [Column("SINSEI_SHO_CD")]
        [Display(Name = "�\����CD")]
        public string? SinseiShoCd { get; set; }

        [Column("SINSEI_SHO_NM")]
        [Display(Name = "�\������")]
        public string? SinseiShoNm { get; set; }

        [Column("SINSEI_SHA_CD")]
        [Display(Name = "�\����CD")]
        public string? SinseiShaCd { get; set; }

        [Column("SINSEI_SHA_NM")]
        [Display(Name = "�\���Җ�")]
        public string? SinseiShaNm { get; set; }

        [Column("SINSEI_CHOAI_CD")]
        [Display(Name = "�\������CD")]
        public string? SinseiChoaiCd { get; set; }

        [Column("SINSEI_CHOAI_NM")]
        [Display(Name = "�\��������")]
        public string? SinseiChoaiNm { get; set; }

        [Column("SINSEI_CHOAI_BUNRUI_CD")]
        [Display(Name = "�\����������CD")]
        public byte? SinseiChoaiBunruiCd { get; set; }

        [Column("SINSEI_SEIKYU_CD")]
        [Display(Name = "�\������CD")]
        public string? SinseiSeikyuCd { get; set; }

        [Column("SINSEI_SEIKYU_NM")]
        [Display(Name = "�\��������")]
        public string? SinseiSeikyuNm { get; set; }

        [Column("SINSEI_SEIKYU_BUNRUI_CD")]
        [Display(Name = "�\����������CD")]
        public byte? SinseiSeikyuBunruiCd { get; set; }

        [Column("SINSEI_SEIKYU_SIMEBI")]
        [Display(Name = "�\����������")]
        public string? SinseiSeikyuSimebi { get; set; }

        [Column("SINSEI_SEIKYU_SHUKIN_BI")]
        [Display(Name = "�\�������W����")]
        public string? SinseiSeikyuShukinBi { get; set; }

        [Column("SINSEI_SEIKYU_KAISHU_SITE")]
        [Display(Name = "�\����������w���")]
        public string? SinseiSeikyuKaishuSite { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_CD")]
        [Display(Name = "�\�������{�XCD")]
        public string? SinseiSeikyuHontenCd { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_NM")]
        [Display(Name = "�\�������{�X��")]
        public string? SinseiSeikyuHontenNm { get; set; }

        [Column("SINSEI_SEIKYU_HONTEN_BUNRUI_CD")]
        [Display(Name = "�\�������{�X����CD")]
        public byte? SinseiSeikyuHontenBunruiCd { get; set; }

        [Column("SINSEI_TOKUI_CD")]
        [Display(Name = "�\�����Ӑ�CD")]
        public string? SinseiTokuiCd { get; set; }

        [Column("SINSEI_TOKUI_NM")]
        [Display(Name = "�\�����Ӑ於")]
        public string? SinseiTokuiNm { get; set; }

        [Column("SINSEI_TOKUI_KANA")]
        [Display(Name = "�\�����Ӑ於�J�i")]
        public string? SinseiTokuiKana { get; set; }

        [Column("SINSEI_TOKUI_BUNRUI_CD")]
        [Display(Name = "�\�����Ӑ敪��CD")]
        public byte? SinseiTokuiBunruiCd { get; set; }

        [Column("SINSEI_TOKUI_GYOTAI_KBN")]
        [Display(Name = "�\�����Ӑ�Ƒԋ敪")]
        public string? SinseiTokuiGyotaiKbn { get; set; }

        [Column("SIHARAI_KEITAI")]
        [Display(Name = "�x���`��")]
        public string? SiharaiKeitai { get; set; }

        [Column("SIHARAI_SHUBETU")]
        [Display(Name = "�x�����")]
        public string? SiharaiShubetu { get; set; }

        [Column("KYOSAN_JOKEN_TANI_KBN")]
        [Display(Name = "���^�����P�ʋ敪")]
        public string? KyosanJokenTaniKbn { get; set; }

        [Column("SINSEI_SEIKYU_NO")]
        [Display(Name = "�\���������ԍ�")]
        public string? SinseiSeikyuNo { get; set; }

        [Column("SINSEI_MITUMORI_NO")]
        [Display(Name = "�\�����Ϗ��ԍ�")]
        public string? SinseiMitumoriNo { get; set; }

        [Column("SINSEI_KEIYAKU_NO")]
        [Display(Name = "�\���_�񏑔ԍ�")]
        public string? SinseiKeiyakuNo { get; set; }

        [Column("SINSEI_KYOSAN_GAKU")]
        [Display(Name = "�\�����^�z")]
        public decimal? SinseiKyosanGaku { get; set; }

        [Column("MIBARAI_KANRI_SIME_YMD")]
        [Display(Name = "�����Ǘ����N����")]
        public string? MibaraiKanriSimeYmd { get; set; }

        [Column("MIBARAI_KANRI_SHORI_SIME_KBN")]
        [Display(Name = "�����Ǘ��������敪")]
        public string? MibaraiKanriShoriSimeKbn { get; set; }

        [Column("KEIYAKU_KEITAI")]
        [Display(Name = "�_��`��")]
        public string? KeiyakuKeitai { get; set; }

        [Column("KEIYAKU_KIKAN")]
        [Display(Name = "�_�����")]
        public byte? KeiyakuKikan { get; set; }

        [Column("SINSEI_ASSOCIATION_CD")]
        [Display(Name = "�\���R�Â�CD")]
        public string? SinseiAssociationCd { get; set; }

        [Column("SINSEI_TOROKU_YMD")]
        [Display(Name = "�\���o�^�N����")]
        public string? SinseiTorokuYmd { get; set; }

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