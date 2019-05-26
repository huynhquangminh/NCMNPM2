import { BookingTicket } from 'src/app/model/booking-ticket-model';
import { Component, OnInit } from '@angular/core';
import { BookingTicketService } from 'src/app/service/booking-ticket.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-bookingticket',
  templateUrl: './bookingticket.component.html',
  styleUrls: ['./bookingticket.component.css']
})
export class BookingticketComponent implements OnInit {
  bookingticket: BookingTicket;
  constructor(private bookingTicketService: BookingTicketService, private router: Router) { }

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
      SoPhong : []
    };
    this.bookingTicketService.setBookingTicket(this.bookingticket);
    this.router.navigate(['home/findroom']);
  }
}
