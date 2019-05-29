import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BookRoomModel } from 'src/app/model/book-room.model';
import { AppService } from 'src/app/service/app-service';
import { Router, ActivatedRoute } from '@angular/router';
import { formatDate } from '@angular/common';

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
