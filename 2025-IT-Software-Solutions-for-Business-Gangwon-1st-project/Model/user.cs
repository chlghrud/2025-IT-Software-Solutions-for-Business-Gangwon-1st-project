//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2025_IT_Software_Solutions_for_Business_Gangwon_1st_project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.add_friend = new HashSet<add_friend>();
            this.add_friend1 = new HashSet<add_friend>();
            this.chat = new HashSet<chat>();
            this.chat1 = new HashSet<chat>();
        }
    
        public int u_no { get; set; }
        public string u_id { get; set; }
        public string u_pw { get; set; }
        public string u_name { get; set; }
        public string u_status_text { get; set; }
        public int u_like_count { get; set; }
        public Nullable<int> u_friend_id { get; set; }
        public System.DateTime u_birthdate { get; set; }
        public byte u_gender { get; set; }
        public string u_friend_fix { get; set; }
        public string u_friend { get; set; }
        public Nullable<int> u_tellpay { get; set; }
        public string u_emoticon { get; set; }
        public byte[] u_profile_image { get; set; }
        public byte[] u_background_image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<add_friend> add_friend { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<add_friend> add_friend1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chat> chat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chat> chat1 { get; set; }
    }
}
