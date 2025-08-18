using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BourbonWeb.Models
{
    [Display(Name = "アプリケーションログ")]
    public class TAppLog
    {
        [Column("ID")]
        [Display(Name = "ID")]
        public long? Id { get; set; }

        [Column("LOG_LEVEL")]
        [Display(Name = "ログレベル")]
        public string? LogLevel { get; set; }

        [Column("PROGRAM_ID")]
        [Display(Name = "プログラムID")]
        public string? ProgramId { get; set; }

        [Column("PROCEDURE_ID")]
        [Display(Name = "プロシージャID")]
        public string? ProcedureId { get; set; }

        [Column("IP_ADDRESS")]
        [Display(Name = "IPアドレス")]
        public string? IpAddress { get; set; }

        [Column("LOGIN_SHO_CD")]
        [Display(Name = "ログイン所CD")]
        public string? LoginShoCd { get; set; }

        [Column("LOGIN_SHO_NM")]
        [Display(Name = "ログイン所名")]
        public string? LoginShoNm { get; set; }

        [Column("LOGIN_SHA_CD")]
        [Display(Name = "ログイン者CD")]
        public string? LoginShaCd { get; set; }

        [Column("LOGIN_SHA_NM")]
        [Display(Name = "ログイン者名")]
        public string? LoginShaNm { get; set; }

        [Column("MESSAGE")]
        [Display(Name = "メッセージ")]
        public string? Message { get; set; }

        [Column("STACK_TRACE")]
        [Display(Name = "スタックトレース")]
        public string? StackTrace { get; set; }

        [Column("REMARKS")]
        [Display(Name = "備考")]
        public string? Remarks { get; set; }

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

        [Column("DELETED_FLG")]
        [Display(Name = "削除フラグ")]
        public bool? DeletedFlg { get; set; }

        [Column("LOCK_VERSION")]
        [Display(Name = "ロックバージョン")]
        public int? LockVersion { get; set; }
    }
}