import { FindroomComponent } from './findroom/findroom.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { LoginComponent } from './login/login.component';
import { TypeRoomComponent } from './type-room/type-room.component';
import { RegisterComponent } from './register/register.component';
import { TypeServiceComponent } from './type-service/type-service.component';
import { IntroduceComponent } from './introduce/introduce.component';
import { ContactComponent } from './contact/contact.component';
import { Page404Component } from './page404/page404.component';
import { BookingticketComponent } from './bookingticket/bookingticket.component';
import { ListbookingComponent } from './listbooking/listbooking.component';
import { BookRoomComponent } from './bookroom/book-room.component';
const homeRoutes: Routes = [
    { path: '', redirectTo: 'index', pathMatch: 'full' },
    { path: 'index', component: IndexComponent },
    // { path: 'product-detail/:id', component: ProductDetailComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'typeroom', component: TypeRoomComponent },
    { path: 'typeservice', component: TypeServiceComponent },
    { path: 'introduce', component: IntroduceComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'findroom', component: FindroomComponent },
    { path: 'booking-ticket', component: BookingticketComponent },
    { path: 'list-booking-ticket', component: ListbookingComponent },
    { path: 'book-room', component: BookRoomComponent },
    // { path: 'news-detail/:id', component: TintucDetailComponent },

    // { path: 'searchproduct/:key', component: FindProductComponent },
     { path: '**', component: Page404Component }

];

@NgModule({
    imports: [
        RouterModule.forChild(homeRoutes)
    ],
    exports: [
        RouterModule
    ]
})
export class HomeRoutingModule { }
