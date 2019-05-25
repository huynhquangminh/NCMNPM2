import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BookingticketComponent } from './bookingticket.component';

describe('BookingticketComponent', () => {
  let component: BookingticketComponent;
  let fixture: ComponentFixture<BookingticketComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BookingticketComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookingticketComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
