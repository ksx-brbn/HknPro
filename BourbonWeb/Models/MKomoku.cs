using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "���ڃ}�X�^")]
    public class MKomoku
    {
        [Column("ky_komoku_cd")]
        [Display(Name = "����CD")]
        public string? KyKomokuCd { get; set; }

        [Column("ky_atai")]
        [Display(Name = "�l")]
        public string? KyAtai { get; set; }

        [Column("hyoji_moji")]
        [Display(Name = "�\������")]
        public string? HyojiMoji { get; set; }

        [Column("def")]
        [Display(Name = "��`")]
        public string? Def { get; set; }

        [Column("toroku_ymd")]
        [Display(Name = "�o�^�N����")]
        public string? TorokuYmd { get; set; }

        [Column("toroku_time")]
        [Display(Name = "�o�^����")]
        public string? TorokuTime { get; set; }

        [Column("delete_flg")]
        [Display(Name = "�폜�t���O")]
        public string? DeleteFlg { get; set; }

        [Column("haisin_flg")]
        [Display(Name = "�z�M�t���O")]
        public string? HaisinFlg { get; set; }

        [Column("haisinbi")]
        [Display(Name = "�z�M��")]
        public string? Haisinbi { get; set; }

    }
}