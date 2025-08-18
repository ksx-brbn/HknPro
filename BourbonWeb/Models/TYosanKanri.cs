using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�\�Z�Ǘ�")]
    public class TYosanKanri
    {
        [Column("URIKAKE_BUNRUI")]
        [Display(Name = "���|����")]
        public string? UrikakeBunrui { get; set; }

        [Column("SEIKYU_KBN")]
        [Display(Name = "�����敪")]
        public string? SeikyuKbn { get; set; }

        [Column("SEIKYU_CD")]
        [Display(Name = "������CD")]
        public string? SeikyuCd { get; set; }

        [Column("SEIKYU_NM")]
        [Display(Name = "�����於")]
        public string? SeikyuNm { get; set; }

        [Column("DENPYO_KBN")]
        [Display(Name = "�`�[�敪")]
        public string? DenpyoKbn { get; set; }

        [Column("HANSOK_KBN")]
        [Display(Name = "�̑��敪")]
        public string? HansokKbn { get; set; }

        [Column("HANSOK_KBN_SHOSAI")]
        [Display(Name = "�̑��敪�ڍ�")]
        public string? HansokKbnShosai { get; set; }

        [Column("HANSOK_KBN_KOBETU")]
        [Display(Name = "�̑��敪��")]
        public string? HansokKbnKobetu { get; set; }

        [Column("HANSOK_HIMOKU_NM")]
        [Display(Name = "�̑���ږ�")]
        public string? HansokHimokuNm { get; set; }

        [Column("TAISHO_YM")]
        [Display(Name = "�Ώ۔N��")]
        public string? TaishoYm { get; set; }

        [Column("YOSAN_GAKU_TOGETU")]
        [Display(Name = "�����\�Z")]
        public decimal? YosanGakuTogetu { get; set; }

        [Column("YOSAN_GAKU_ZENGETU")]
        [Display(Name = "�O���\�Z")]
        public decimal? YosanGakuZengetu { get; set; }

        [Column("YOSAN_GAKU_ZEN2GETU")]
        [Display(Name = "�O�X���\�Z")]
        public decimal? YosanGakuZen2getu { get; set; }

        [Column("YOSAN_GAKU_KURIKOSI")]
        [Display(Name = "�J�z���\�Z")]
        public decimal? YosanGakuKurikosi { get; set; }

        [Column("KYOSAN_GAKU_TOGETU")]
        [Display(Name = "�������ы��^�z")]
        public decimal? KyosanGakuTogetu { get; set; }

        [Column("KYOSAN_GAKU_ZENGETU")]
        [Display(Name = "�O�����ы��^�z")]
        public decimal? KyosanGakuZengetu { get; set; }

        [Column("KYOSAN_GAKU_ZEN2GETU")]
        [Display(Name = "�O�X�����ы��^�z")]
        public decimal? KyosanGakuZen2getu { get; set; }

        [Column("ZEN2GETU_FUSOKU_GAKU")]
        [Display(Name = "�O�X���\�Z���ߊz")]
        public decimal? Zen2getuFusokuGaku { get; set; }

        [Column("JIGETU_KURIKOSI_GAKU")]
        [Display(Name = "�����J�z�z")]
        public decimal? JigetuKurikosiGaku { get; set; }

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