
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './index/index.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeRoutingModule } from './home-routing.module';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { RoomComponent } from './room/room.component';
import { TypeRoomComponent } from './type-room/type-room.component';
import { TypeServiceComponent } from './type-service/type-service.component';
import { FooterComponent } from './footer/footer.component';
import { AppService } from '../service/app-service';

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
    RoomComponent,
    TypeRoomComponent,
    TypeServiceComponent,
  ],
  providers: []
})
export class HomeModule { }
