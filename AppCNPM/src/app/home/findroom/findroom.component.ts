import { BookingTicketService } from './../../service/booking-ticket.service';

import { Component, OnInit, ElementRef } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { GETROOM_URL } from './config';
import { BookingTicket } from 'src/app/model/booking-ticket-model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { formatDate } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-findroom',
  templateUrl: './findroom.component.html',
  styleUrls: ['./findroom.component.css']
})
export class FindroomComponent implements OnInit {
  listRoom: any;
  public addForm: FormGroup;
  booking = new  BookingTicket();
  urlImage = 'http://localhost:3100/image/';
  arrPhong = [];
  ishidden: true;
  constructor(
    private service: AppService,
    private bookingTicketService: BookingTicketService,
    private formBuilder: FormBuilder, private router: Router) {

    this.addForm = this.formBuilder.group({
      DateStart: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],
      DateEnd: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],

    });
  }

  ngOnInit() {
    this.getListRoom();
  }
  getListRoom() {
    this.service.CallAllService(GETROOM_URL).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.listRoom = data.ListRoomAll;
        }
      }
    });
  }


  btnClick(value) {
    const id = 'btn_' + value;
    if (document.getElementById(id).innerHTML === 'Chọn Phòng') {
      document.getElementById(id).className = 'btn btn-default';
      document.getElementById(id).innerHTML = 'Hủy Phòng';
      this.arrPhong.push(value);
    } else {
      document.getElementById(id).className = 'btn btn-success';
      document.getElementById(id).innerHTML = 'Chọn Phòng';
      this.arrPhong.splice(this.arrPhong.indexOf(value), 1);
    }

  }

  btnHoanTat() {
    if (this.addForm.get('DateStart').value > this.addForm.get('DateEnd').value
      || this.addForm.get('DateStart').value < formatDate(new Date(), 'yyyy-MM-dd', 'en')) {
      alert('Ngày Bắt đầu phải nhỏ hơn ngày kết thúc và lớn hơn ngày hiện tại ');
    } else {
      if (this.arrPhong.length === 0 || this.arrPhong == null) {
        alert('Bạn chưa chọn Phòng');
      } else {
        this.booking.startDate = this.addForm.get('DateStart').value;
        this.booking.endDate = this.addForm.get('DateEnd').value;
        this.booking.SoPhong = this.arrPhong;
        this.bookingTicketService.setBookingTicket(this.booking);
        this.router.navigate(['home/booking-ticket']);
      }
    }
  }

}
