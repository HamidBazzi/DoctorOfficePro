using System.ComponentModel.DataAnnotations;

namespace DoctorOfficePro.Data
{
    public class Patient
    {
        // Primary Key
        [Key]
        public int Id { get; set; }

        // نام 
        [Required(ErrorMessage = "لطفاً نام بیمار را وارد کنید.")]
        [MaxLength(50, ErrorMessage = "نام نباید بیشتر از 50 حرف باشد.")]
        public string FirstName { get; set; }

        // نام خانوادگی
        [Required(ErrorMessage = "لطفاً نام خانوادگی بیمار را وارد کنید.")]
        [MaxLength(150, ErrorMessage = "نام خانوادگی نباید بیشتر از 150 حرف باشد.")]
        public string LastName { get; set; }

        // کد ملی
        [Required(ErrorMessage = "لطفاً کد ملی بیمار را وارد کنید.")]
        [MaxLength(10, ErrorMessage = "کد ملی نباید بیشتر از 10 رقم باشد.")]
        [MinLength(10, ErrorMessage = "کد ملی نباید کمتر از 10 رقم باشد.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی باید شامل 10 رقم عددی باشد.")]
        public string NationalCode { get; set; }

        // تاریخ تولد
        [Required(ErrorMessage = "لطفاً تاریخ تولد بیمار را وارد کنید.")]
        public DateTime DateOfBirth { get; set; }

        // جنسیت
        [Required(ErrorMessage = "لطفاً جنسیت بیمار را انتخاب کنید.")]
        public Gender Gender { get; set; }

        // شماره تماس
        [Required(ErrorMessage = "لطفاً شماره تماس بیمار را وارد کنید.")]
        [MaxLength(11, ErrorMessage = "شماره تماس نباید بیشتر از 11 رقم باشد.")]
        [MinLength(11, ErrorMessage = "شماره تماس نباید کمتر از 11 رقم باشد.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "شماره تماس باید شامل ارقام باشد.")]
        public string PhoneNumber { get; set; }

        // ایمیل (اختیاری)
        [MaxLength(100, ErrorMessage = "ایمیل نباید بیشتر از 100 حرف باشد.")]
        [EmailAddress(ErrorMessage = "لطفاً یک آدرس ایمیل معتبر وارد کنید.")]
        public string? Email { get; set; }

        // آدرس
        [MaxLength(200, ErrorMessage = "آدرس نباید بیشتر از 200 حرف باشد.")]
        public string? Address { get; set; }

        // نوع بیمه
        [Required(ErrorMessage = "لطفاً نوع بیمه بیمار را انتخاب کنید.")]
        public InsuranceType InsuranceType { get; set; }

        // شماره بیمه (اختیاری)
        [MaxLength(20, ErrorMessage = "شماره بیمه نباید بیشتر از 20 حرف یا عدد باشد.")]
        public string? InsuranceNumber { get; set; }

        // گروه خونی (اختیاری)
        public BloodType? BloodType { get; set; }

        // حساسیت‌ها (اختیاری)
        [MaxLength(500, ErrorMessage = "فیلد حساسیت‌ها نباید بیشتر از 500 حرف باشد.")]
        public string? Allergies { get; set; }

        // بیماری‌های مزمن (اختیاری)
        [MaxLength(500, ErrorMessage = "فیلد بیماری‌های مزمن نباید بیشتر از 500 حرف باشد.")]
        public string? ChronicDiseases { get; set; }

        // تاریخ ثبت بیمار
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // تاریخ آخرین به‌روزرسانی (اختیاری)
        public DateTime? UpdatedAt { get; set; }
    }

    // Enum برای جنسیت
    public enum Gender
    {
        [Display(Name = "مرد")]
        Male,

        [Display(Name = "زن")]
        Female,

        [Display(Name = "دیگر")]
        Other
    }

    // Enum برای نوع بیمه
    public enum InsuranceType
    {
        [Display(Name = "تامین اجتماعی")]
        SocialSecurity,

        [Display(Name = "خدمات درمانی")]
        MedicalServices,

        [Display(Name = "نیروهای مسلح")]
        ArmedForces,

        [Display(Name = "سلامت")]
        HealthInsurance,

        [Display(Name = "آزاد")]
        Free
    }

    // Enum برای گروه خونی
    public enum BloodType
    {
        [Display(Name = "A+")]
        APositive,

        [Display(Name = "A-")]
        ANegative,

        [Display(Name = "B+")]
        BPositive,

        [Display(Name = "B-")]
        BNegative,

        [Display(Name = "AB+")]
        ABPositive,

        [Display(Name = "AB-")]
        ABNegative,

        [Display(Name = "O+")]
        OPositive,

        [Display(Name = "O-")]
        ONegative
    }
}
