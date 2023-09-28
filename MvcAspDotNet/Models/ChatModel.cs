using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAspDotNet.Models
{
    public class ChatModel
    {
        [Key]
        public int? chat_id { get; set; }

        public int? sender_id { get; set; }

        public int? receiver_id { get; set; }

        public string? message { get; set; }

        public DateTime? datetime { get; set; }
    }
}
