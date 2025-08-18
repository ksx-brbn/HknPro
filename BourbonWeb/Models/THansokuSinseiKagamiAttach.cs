using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "�̑���\���ӓY�t���")]
    public class THansokuSinseiKagamiAttach
    {
        [Column("KAISHA_CD")]
        [Display(Name = "���CD")]
        public string? KaishaCd { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "�\�����ԍ�")]
        public string? SinseiKagamiNo { get; set; }

        [Column("GYO_NO")]
        [Display(Name = "�sNo")]
        public short? GyoNo { get; set; }

        [Column("FILE_TITLE")]
        [Display(Name = "�t�@�C���^�C�g��")]
        public string? FileTitle { get; set; }

        [Column("FILE_NM")]
        [Display(Name = "�t�@�C����")]
        public string? FileNm { get; set; }

        [Column("EXTENSION")]
        [Display(Name = "�t�@�C���g���q")]
        public string? Extension { get; set; }

        [Column("DATA_IMG")]
        [Display(Name = "�t�@�C���C���[�W")]
        public byte[]? DataImg { get; set; }

        [Column("FILE_SIZE")]
        [Display(Name = "�t�@�C���C���[�W�T�C�Y")]
        public int? FileSize { get; set; }

        [Column("MATERIAL_TYP")]
        [Display(Name = "�������")]
        public string? MaterialTyp { get; set; }

        [Column("REMARKS")]
        [Display(Name = "���l")]
        public string? Remarks { get; set; }

        [Column("RESERVE1")]
        [Display(Name = "�\���P")]
        public string? Reserve1 { get; set; }

        [Column("RESERVE2")]
        [Display(Name = "�\���Q")]
        public string? Reserve2 { get; set; }

        [Column("RESERVE3")]
        [Display(Name = "�\���R")]
        public string? Reserve3 { get; set; }

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
    }
}