﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Lütfen fiyat bilgisi giriniz.")]
        
        public int Price { get; set; }
        [Required(ErrorMessage ="Lütfen oda için başlık giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen duş sayısı giriniz")]
        public string BathCount { get; set; }
        
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız.")]
        public string Description { get; set; }
    }
}