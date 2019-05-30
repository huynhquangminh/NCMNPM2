import { AppService } from './../../service/app-service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { GET_LIST_BOOKINGTICKET_URL, FIND_BOOKINGTICKET_URL, UPDATE_BOOKINGTICKET_URL, DELETE_BOOKINGTICKET_URL } from './config';
import { GetListOrderFromIdentitycardRequest } from 'src/app/model/find-booking-ticket.request';
import { UpdateBookingTicketRequest } from 'src/app/model/update-booking-ticket.request';
import { DeleteBookingTicketRequest } from 'src/app/model/delete-booking-ticket.request';
import { Router } from '@angular/router';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-listbooking',
  templateUrl: './listbooking.component.html',
  styleUrls: ['./listbooking.component.css']
})
export class ListbookingComponent implements OnInit {
  listBooking: any;
  keycmnd: string;
  findRequest = new GetListOrderFromIdentitycardRequest();
  updateBookingTicketRequest = new UpdateBookingTicketRequest();
  deleteBookingTicketRequest = new DeleteBookingTicketRequest();
  isThongbao = false;
  public addForm: FormGroup;
  urlImage = 'http://localhost:3100/image/';
  constructor(private appService: AppService, private formBuilder: FormBuilder, private router: Router) {
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
  btnBookRoom(data) {
    const ngayVao = formatDate(data.NgayVao, 'yyyy-MM-dd', 'en');
    const ngayRa = formatDate(data.NgayVao, 'yyyy-MM-dd', 'en');
    this.router.navigate(['/home/book-room',
    { isbook: 'true', id: data.ID, sophong: data.SoPhong, ngayvao: ngayVao, ngayra: ngayRa, cmnd: data.CMND }]);
  }
  btnComfrim(value) {
    this.updateBookingTicketRequest = {
      ID: value,
      TinhTrang: 1,
      TinhTrangDatPhong: 0
    };
    this.appService.CallByResquestService(UPDATE_BOOKINGTICKET_URL, this.updateBookingTicketRequest).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          alert('Xác nhận thành công! ');
          this.getListBookingTicket();
        }
      }
    });
  }
  btnCancle(value) {
    this.deleteBookingTicketRequest.ID = value;
    this.appService.CallByResquestService(DELETE_BOOKINGTICKET_URL, this.deleteBookingTicketRequest).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.getListBookingTicket();
        }
      }
    });
  }
}
