import { AppService } from './../../service/app-service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { GET_LIST_BOOKINGTICKET_URL, FIND_BOOKINGTICKET_URL } from './config';
import { GetListOrderFromIdentitycardRequest } from 'src/app/model/find-booking-ticket.request';

@Component({
  selector: 'app-listbooking',
  templateUrl: './listbooking.component.html',
  styleUrls: ['./listbooking.component.css']
})
export class ListbookingComponent implements OnInit {
  listBooking: any;
  keycmnd: string;
  findRequest = new GetListOrderFromIdentitycardRequest();
  isThongbao = false;
  public addForm: FormGroup;
  urlImage = 'http://localhost:3100/image/';
  constructor(private appService: AppService, private formBuilder: FormBuilder) {
    this.addForm = this.formBuilder.group({
      CMND: [, [Validators.required]],
    });
  }

  ngOnInit() {
    this.getListBookingTicket();
  }
  getListBookingTicket() {
    this.appService.CallAllService(GET_LIST_BOOKINGTICKET_URL).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.listBooking = data.ListBookingTicket;
        }
      }
    });
  }
  searchBookingTicket(value) {
    this.findRequest.CMND = value;
    this.appService.CallByResquestService(FIND_BOOKINGTICKET_URL, this.findRequest).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.listBooking = data.ListRoom;
          if (this.listBooking.length === 0) {
            this.isThongbao = true;
          } else {
            this.isThongbao = false;
          }
        }
      }
    });
  }

}
