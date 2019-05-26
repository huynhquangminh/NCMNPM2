import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { BookingTicket } from '../model/booking-ticket-model';


// npm install rxjs@6 rxjs-compat@6 --save
@Injectable()
export class BookingTicketService {
    arrBooking: BookingTicket;
    constructor() { }
    getBookingTicket() {
        return this.arrBooking;
    }

    setBookingTicket(data: BookingTicket) {
        this.arrBooking = data;
    }
}
