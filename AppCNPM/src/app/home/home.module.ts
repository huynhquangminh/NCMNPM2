
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeRoutingModule } from './home-routing.module';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { BookRoomComponent } from './bookroom/book-room.component';
import { TypeRoomComponent } from './type-room/type-room.component';
import { TypeServiceComponent } from './type-service/type-service.component';
import { FooterComponent } from './footer/footer.component';
import { IntroduceComponent } from './introduce/introduce.component';
import { FindroomComponent } from './findroom/findroom.component';
import { BillComponent } from './bill/bill.component';
import { ContactComponent } from './contact/contact.component';
import { Page404Component } from './page404/page404.component';
import { BookingticketComponent } from './bookingticket/bookingticket.component';
import { RoomdetailComponent } from './roomdetail/roomdetail.component';
import { ListbookingComponent } from './listbooking/listbooking.component';
import { OrderserviceComponent } from './orderservice/orderservice.component';
import { ListorderserviceComponent } from './listorderservice/listorderservice.component';
import { ListbookroomComponent } from './listbookroom/listbookroom.component';
import { EditbookroomComponent } from './editbookroom/editbookroom.component';

@NgModule({
  imports: [
    CommonModule,
    HomeRoutingModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
  ],
  declarations: [
    IndexComponent,
    LoginComponent,
    RegisterComponent,
    BookRoomComponent,
    TypeRoomComponent,
    TypeServiceComponent,
    IntroduceComponent,
    FindroomComponent,
    BillComponent,
    ContactComponent,
    Page404Component,
    BookingticketComponent,
    RoomdetailComponent,
    ListbookingComponent,
    OrderserviceComponent,
    ListorderserviceComponent,
    ListbookroomComponent,
    EditbookroomComponent,
  ],
  providers: []
})
export class HomeModule { }
