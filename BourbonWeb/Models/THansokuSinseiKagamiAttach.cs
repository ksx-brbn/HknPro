using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "販促費申請鑑添付情報")]
    public class THansokuSinseiKagamiAttach
    {
        [Column("KAISHA_CD")]
        [Display(Name = "会社CD")]
        public string? KaishaCd { get; set; }

        [Column("SINSEI_KAGAMI_NO")]
        [Display(Name = "申請鏡番号")]
        public string? SinseiKagamiNo { get; set; }

        [Column("GYO_NO")]
        [Display(Name = "行No")]
        public short? GyoNo { get; set; }

        [Column("FILE_TITLE")]
        [Display(Name = "ファイルタイトル")]
        public string? FileTitle { get; set; }

        [Column("FILE_NM")]
        [Display(Name = "ファイル名")]
        public string? FileNm { get; set; }

        [Column("EXTENSION")]
        [Display(Name = "ファイル拡張子")]
        public string? Extension { get; set; }

        [Column("DATA_IMG")]
        [Display(Name = "ファイルイメージ")]
        public byte[]? DataImg { get; set; }

        [Column("FILE_SIZE")]
        [Display(Name = "ファイルイメージサイズ")]
        public int? FileSize { get; set; }

        [Column("MATERIAL_TYP")]
        [Display(Name = "資料種別")]
        public string? MaterialTyp { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

        [Column("RESERVE1")]
        [Display(Name = "予備１")]
        public string? Reserve1 { get; set; }

        [Column("RESERVE2")]
        [Display(Name = "予備２")]
        public string? Reserve2 { get; set; }

        [Column("RESERVE3")]
        [Display(Name = "予備３")]
        public string? Reserve3 { get; set; }

        [Column("CREATED_ID")]
        [Display(Name = "登録者")]
        public string? CreatedId { get; set; }

        [Column("CREATED_AT")]
        [Display(Name = "登録日")]
        public DateTime? CreatedAt { get; set; }

        [Column("UPDATED_ID")]
        [Display(Name = "更新者")]
        public string? UpdatedId { get; set; }

        [Column("UPDATED_AT")]
        [Display(Name = "更新日")]
        public DateTime? UpdatedAt { get; set; }
    }
}