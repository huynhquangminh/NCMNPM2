import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BookRoomModel } from 'src/app/model/book-room.model';
import { AppService } from 'src/app/service/app-service';
import { Router, ActivatedRoute } from '@angular/router';
import { formatDate } from '@angular/common';
import { UPDATE_BOOK_ROOM_URL } from '../config';

@Component({
  selector: 'app-updatebookroom',
  templateUrl: './updatebookroom.component.html',
  styleUrls: ['./updatebookroom.component.css']
})
export class UpdatebookroomComponent implements OnInit {

  public addForm: FormGroup;
  bookRoomModel = new BookRoomModel();
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
    this.bookRoomModel.SoPhong = Number(this.checkrouter = this.route.snapshot.paramMap.get('sophong'));
    this.bookRoomModel.NgayVao = formatDate(new Date(this.route.snapshot.paramMap.get('ngayvao')), 'yyyy-MM-dd', 'en');
    this.bookRoomModel.NgayRa = formatDate(new Date(this.route.snapshot.paramMap.get('ngayra')), 'yyyy-MM-dd', 'en');
    this.bookRoomModel.CMND = this.route.snapshot.paramMap.get('cmnd');
    this.bookRoomModel.TenKhachHang = this.route.snapshot.paramMap.get('tenkh');
    this.bookRoomModel.ID = Number(this.route.snapshot.paramMap.get('id'));
  }

  btnChangeBookRoom() {
    if (this.addForm.valid) {
      if (!this.checkDayBooking()) {
        this.bookRoomModel.idNV = 1;
        this.bookRoomModel.TinhTrang = 0;
        this.appService.CallByResquestService(UPDATE_BOOK_ROOM_URL, this.bookRoomModel).subscribe( item => {
          if (item) {
            if (item.Success === false) {
              alert('Your Request Is Unsuccessful');
            } else {
              alert('Book room successful');
              this.router.navigate(['/home/list-book-room']);
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
