import { AppService } from './../../service/app-service';
import { BookingTicket } from 'src/app/model/booking-ticket-model';
import { Component, OnInit } from '@angular/core';
import { BookingTicketService } from 'src/app/service/booking-ticket.service';
import { Router } from '@angular/router';
import { InsertBookingTicketRequest } from 'src/app/model/insert-booking-ticket.request';
import { INSERT_BOOKING_TICKET_URL } from './config';

@Component({
  selector: 'app-bookingticket',
  templateUrl: './bookingticket.component.html',
  styleUrls: ['./bookingticket.component.css']
})
export class BookingticketComponent implements OnInit {
  bookingticket: BookingTicket;
  insertBookingTicketRequest = new InsertBookingTicketRequest();
  constructor(
    private bookingTicketService: BookingTicketService,
    private router: Router,
    private appService: AppService) { }

  ngOnInit() {
    this.setInfoTicket();
  }
  setInfoTicket() {
    this.bookingticket = this.bookingTicketService.getBookingTicket();
  }

  btncancel() {
    this.bookingticket = {
      startDate: null,
      endDate: null,
      SoPhong: []
    };
    this.bookingTicketService.setBookingTicket(this.bookingticket);
    this.router.navigate(['home/findroom']);
  }
  btnComfrim() {
    let i;
    let tamp = 0;
    for (i = 0; i < this.bookingticket.SoPhong.length; i++) {
      this.insertBookingTicketRequest = {
        SoPhong: this.bookingticket.SoPhong[i],
        NgayVao: this.bookingticket.startDate.toString(),
        NgayRa: this.bookingticket.endDate.toString(),
        TinhTrang: 0,
        idKhachHang: '123456'  // lay thong tin khach hang
      };
      this.appService.CallByResquestService(INSERT_BOOKING_TICKET_URL, this.insertBookingTicketRequest).subscribe(data => {
        if (data) {
          if (data.Success === false) {
            alert('Your Request Is Unsuccessful');
          } else {
            tamp++;
            if (tamp === this.bookingticket.SoPhong.length) {
              alert('Đặt Phòng Thành công.');
              this.router.navigate(['home/findroom']);
            }
          }
        }
      });
    }
  }
}
