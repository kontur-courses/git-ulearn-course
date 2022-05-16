import { expect } from "chai";
import sum from "./sum";

describe('Тест на сложение.', () => {
  it('Должен складывать числа', () => {
    expect(sum(2, 2)).to.equal(4);
  });
  it('Должен складывать строки', () => {
    expect(sum("2", "2")).to.equal("22");
  });
});
