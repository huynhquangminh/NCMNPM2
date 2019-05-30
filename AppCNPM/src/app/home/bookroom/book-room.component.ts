import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BookRoomModel } from 'src/app/model/book-room.model';
import { Router, ActivatedRoute } from '@angular/router';
import { INSERT_BOOK_ROOM_URL } from './config';
import { formatDate } from '@angular/common';
import { UpdateBookingTicketRequest } from 'src/app/model/update-booking-ticket.request';
import { UPDATE_BOOKINGTICKET_URL } from '../listbooking/config';

@Component({
  selector: 'app-bookroom',
  templateUrl: './book-room.component.html',
  styleUrls: ['./book-room.component.css']
})
export class BookRoomComponent implements OnInit {
  public addForm: FormGroup;
  bookRoomModel = new BookRoomModel();
  bookingticketRequest = new UpdateBookingTicketRequest();
  checkrouter: string;
  startDate: Date;
  endDate: Date;
  dayDate: Date;
  constructor(
    private appService: AppService,
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute) {
    this.addForm = this.formBuilder.group({
      SoPhong: [, [Validators.required]],
      NgayVao: [, [Validators.required]],
      NgayRa: [, [Validators.required]],
      TenKhachHang: [, [Validators.required]],
      CMND: [, [Validators.required]],
    });
  }

  ngOnInit() {
    this.checkrouter = this.route.snapshot.paramMap.get('isbook');
    if (this.checkrouter === 'true') {
      this.bookRoomModel.SoPhong = Number(this.checkrouter = this.route.snapshot.paramMap.get('sophong'));
      this.bookRoomModel.NgayVao = formatDate(new Date(this.route.snapshot.paramMap.get('ngayvao')), 'yyyy-MM-dd', 'en');
      this.bookRoomModel.NgayRa = formatDate(new Date(this.route.snapshot.paramMap.get('ngayra')), 'yyyy-MM-dd', 'en');
      this.bookRoomModel.CMND = this.route.snapshot.paramMap.get('cmnd');
    }
  }
  btnBookRoom() {
    if (this.addForm.valid) {
      if (!this.checkDayBooking()) {
        this.bookRoomModel.idNV = 1;
        this.bookRoomModel.TinhTrang = 0;
        this.appService.CallByResquestService(INSERT_BOOK_ROOM_URL, this.bookRoomModel).subscribe(data => {
          if (data) {
            if (data.Success === false) {
              alert('Your Request Is Unsuccessful');
            } else {
              alert('Book room successful');
              if (this.checkrouter === 'true') {
                this.bookingticketRequest.ID = Number(this.route.snapshot.paramMap.get('id'));
                this.bookingticketRequest.TinhTrang = 1;
                this.bookingticketRequest.TinhTrangDatPhong = 1;
                this.appService.CallByResquestService(UPDATE_BOOKINGTICKET_URL, this.bookingticketRequest).subscribe(item => {
                });
              }
              this.bookRoomModel.SoPhong = null;
            }
          }
        });
      } else {
        alert('Ngày Bắt đầu phải nhỏ hơn ngày kết thúc và lớn hơn ngày hiện tại ');
      }
    }
  }

  checkDayBooking(): boolean {
    this.startDate = new Date(this.addForm.get('NgayVao').value);
    this.endDate = new Date(this.addForm.get('NgayRa').value);
    this.dayDate = new Date();
    if (this.startDate > this.endDate) {
      return true;
    }
  }
  btnBookingTicket() {
    this.router.navigate(['/home/list-booking-ticket']);
  }
  btnListRoom() {
    this.router.navigate(['/home/findroom']);
  }

  btnBookingRoom() {
    this.router.navigate(['/home/list-book-room']);
  }

}
