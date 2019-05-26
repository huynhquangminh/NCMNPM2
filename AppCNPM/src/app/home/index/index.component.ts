import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { formatDate } from '@angular/common';
import { AppService } from 'src/app/service/app-service';
import { GETPOSTALL_UTL } from './config';
import { Router } from '@angular/router';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  public indexform: FormGroup;
  listPost: any;
  startDate: Date;
  endDate: Date;
  urlImage = 'http://localhost:3100/image/';
  constructor(private formBuilder: FormBuilder, private service: AppService, private router: Router) {
    this.indexform = this.formBuilder.group({
      DateStart: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],
      DateEnd: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],

    });
  }

  ngOnInit() {
    this.callService();
  }
  callService() {
    this.service.CallAllService(GETPOSTALL_UTL).subscribe(
      data => {
        if (data) {
          if (data.Success === false) {
            alert('Your Request Is Unsuccessful');
          } else {
            this.listPost = data.ListPosts;
          }
        }
      });
  }
  OnBookNow() {
    if (this.indexform.get('DateStart').value > this.indexform.get('DateEnd').value
      || this.indexform.get('DateStart').value < formatDate(new Date(), 'yyyy-MM-dd', 'en')) {
      alert('Ngày Bắt đầu phải nhỏ hơn ngày kết thúc và lớn hơn ngày hiện tại ');
    } else {
      this.router.navigate(['/home/findroom']);
    }
  }
}
