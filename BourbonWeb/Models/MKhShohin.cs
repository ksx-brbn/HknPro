using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���i�̑����i�}�X�^")]
    public class MKhShohin
    {
        [Column("KAKAKU_HANSOKU_NO")]
        [Display(Name = "���i�̑��ԍ�")]
        public string? KakakuHansokuNo { get; set; }

        [Column("KAKAKU_HANSOKU_GYO_NO")]
        [Display(Name = "���i�̑��s�ԍ�")]
        public int? KakakuHansokuGyoNo { get; set; }

        [Column("HINBAN")]
        [Display(Name = "�i��")]
        public string? Hinban { get; set; }

        [Column("SHOHIN_NM")]
        [Display(Name = "���i��")]
        public string? ShohinNm { get; set; }

        [Column("SHOHIN_GROUP_NM")]
        [Display(Name = "���i�O���[�v��")]
        public string? ShohinGroupNm { get; set; }

        [Column("EIGYO_BUNRUI")]
        [Display(Name = "�c�ƕ���")]
        public string? EigyoBunrui { get; set; }

        [Column("CATEGORY_BUNRUI")]
        [Display(Name = "�J�e�S���[����")]
        public string? CategoryBunrui { get; set; }

        [Column("OYA_HINBAN")]
        [Display(Name = "�e�i��")]
        public string? OyaHinban { get; set; }

        [Column("IRISU")]
        [Display(Name = "���萔")]
        public string? Irisu { get; set; }

        [Column("TANKA")]
        [Display(Name = "�P��")]
        public decimal? Tanka { get; set; }

        [Column("SHOHIN_REMARKS1")]
        [Display(Name = "���i���l1")]
        public string? ShohinRemarks1 { get; set; }

        [Column("SHOHIN_REMARKS2")]
        [Display(Name = "���i���l2")]
        public string? ShohinRemarks2 { get; set; }

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

        [Column("HANSOK_HIMOKU_CD")]
        [Display(Name = "�̑����CD")]
        public string? HansokHimokuCd { get; set; }

        [Column("HANSOK_HIMOKU_NM")]
        [Display(Name = "�̑���ږ�")]
        public string? HansokHimokuNm { get; set; }

        [Column("KYOSAN_JOKEN_RITU")]
        [Display(Name = "���^����")]
        public decimal? KyosanJokenRitu { get; set; }

        [Column("KYOSAN_JOKEN_GAKU")]
        [Display(Name = "���^�����z")]
        public decimal? KyosanJokenGaku { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "�o�^��")]
        public DateTime? CreatedAt { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "�o�^��")]
        public string? CreatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "�X�V��")]
        public DateTime? UpdatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "�X�V��")]
        public string? UpdatedId { get; set; }

        [Column("DELETED_FLG")]
        [Display(Name = "�폜�t���O")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "���b�N�o�[�W����")]
        public int? LockVersion { get; set; }
    }
}