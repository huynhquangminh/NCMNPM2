import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderserviceComponent } from './orderservice.component';

describe('OrderserviceComponent', () => {
  let component: OrderserviceComponent;
  let fixture: ComponentFixture<OrderserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrderserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrderserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
