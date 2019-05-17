import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { formatDate } from '@angular/common';
import { AppService } from 'src/app/service/app-service';
import { GETPOSTALL_UTL } from './config';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  public addForm: FormGroup;
  listPost: any;
  urlImage = 'http://localhost:3100/image/';
  constructor(private formBuilder: FormBuilder, private service: AppService) {
    this.addForm = this.formBuilder.group({
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
    if (this.addForm.get('DateStart').value >= this.addForm.get('DateEnd').value
      || this.addForm.get('DateStart').value < formatDate(new Date(), 'yyyy-MM-dd', 'en')) {
      alert('Ngày Bắt đầu phải nhỏ hơn ngày kết thúc và lớn hơn ngày hiện tại ');
    }
  }
}
