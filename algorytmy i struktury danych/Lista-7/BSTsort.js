function TreeNode(val, left, right) {
  this.val = val;
  this.left = left;
  this.right = right;
}
const inorder = (root) => {
  const nodes = [];
  if (root) {
    inorder(root.left);
    nodes.push(root.val);
    inorder(root.right);
  }
  return nodes;
};

const preorder = (root) => {
  const nodes = [];
  if (root) {
    nodes.push(root.val);
    preorder(root.left);
    preorder(root.right);
  }
  return nodes;
};
const maxDepth = function (root) {
  const calc = (node) => {
    if (!node) return 0;
    return Math.max(1 + calc(node.left), 1 + calc(node.right));
  };
  return calc(root);
};
const minDepth = function (root) {
  const calc = (node) => {
    if (!node) return 0;
    return Math.min(1 + calc(node.left), 1 + calc(node.right));
  };
  return calc(root);
};
insert(data);

var tree = new TreeNode();

class BinarySearchTree {
  constructor() {
    this.root = null;
  }
  insert(value) {
    var newNode = new Node(value);
    if (this.root === null) {
      this.root = newNode;
      return this;
    } else {
      var current = this.root;
      while (true) {
        if (value === current) return undefined;
        if (value < current.value) {
          if (current.left === null) {
            current.left = newNode;
            return this;
          } else {
            current = current.left;
          }
        } else if (value > current.value) {
          if (current.right === null) {
            current.right = newNode;
          }
          return this;
        } else {
          current = current.right;
        }
      }
    }
  }
}
tree.insert(10);
tree.insert(8);
tree.insert(4);
tree.insert(2);
tree.insert(6);
tree.insert(7);

// var NodeTree2 = new TreeNode(7, 5, 6);
// console.log("Pre-order: " + preorder(NodeTree2));
// console.log("In-Order: " + inorder(NodeTree2));
// console.log("Max: " + maxDepth(NodeTree2));
